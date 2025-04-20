using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NHunspellComponent.Spelling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace RPGMakerSpellChecker
{
    public partial class Form_RPGMakerSpellCheck : Form, IMessageFilter
    {
        JObject mapObject;
        JArray mapEvents;
        JObject theEvent;
        JArray thePages;
        JObject thePage;
        JArray theList;

        string mapName; // TODO load this from MapInfos
        int eventIndex = 1;
        int pageIndex = 0;
        int listIndex = -1;
        string currentEventText = "";

        string mode = "none"; // todo eventually we'll support choices.

        string loadedFileName = "";
        bool alreadyWarnedAboutMV = false;

        public Form_RPGMakerSpellCheck()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
            VLabel_MouseScroll.MouseWheel += VLabel_MouseScroll_MouseWheel;
            VLabel_MouseScroll2.MouseWheel += VLabel_MouseScroll_MouseWheel;
            RTB_EventText.IsSpellingEnabled = true;
            RTB_EventText.IsSpellingAutoEnabled = true;
            this.Icon = Properties.Resources.spellcheckericon;
        }

        // message filter for scroll wheel. from https://stackoverflow.com/a/10006877
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x20a)
            {
                // WM_MOUSEWHEEL, find the control at screen position m.LParam
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                IntPtr hWnd = WindowFromPoint(pos);
                if (hWnd != IntPtr.Zero && hWnd != m.HWnd && Control.FromHandle(hWnd) != null)
                {
                    SendMessage(hWnd, m.Msg, m.WParam, m.LParam);
                    return true;
                }
            }
            return false;
        }

        // P/Invoke declarations
        [DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(Point pt);
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        // ui stuff

        private void UpdateRTB()
        {
            RTB_EventText.Clear();
            RTB_EventText.Text = currentEventText;
            spellingWorker1.ProgramLoadedText();
            RTB_EventText.ClearUndo();
            RTB_EventText.Update();

            Label_Event.Text = "EV" + eventIndex.ToString("D3");
            Label_Page.Text = (pageIndex + 1).ToString();
            Label_EventName.Text = getCurrentEventName();
        }

        private void CheckSpelling()
        {
            NHunspellWrapper.Instance.CloseCheckAllWindow();
            Timer_CheckSpelling.Start();
        }




        // loady stuf

        private string getCurrentEventName()
        {
            if (theEvent == null) { return ""; }
            JValue name = (JValue)theEvent["name"];
            return name.ToObject<string>();
        }

        private void slurpDataFromMap()
        {
            if (mapObject == null) { throw new NullReferenceException(); }

            mapEvents = (JArray)mapObject["events"];
            eventIndex = 1; // todo a map might not have any events.
            pageIndex = 0;
            listIndex = -1; // we increment this in the search
            mode = "none";
        }

        private void reloadEventsUpToList()
        {
            eventIndex = Math.Max(1, Math.Min(mapEvents.Count - 1, eventIndex));
            theEvent = (JObject)mapEvents[eventIndex];
            thePages = (JArray)theEvent["pages"];
            pageIndex = Math.Max(0, Math.Min(thePages.Count - 1, pageIndex));
            thePage = (JObject)thePages[pageIndex];
            theList = (JArray)thePage["list"];
            listIndex = Math.Max(0, Math.Min(theList.Count - 1, listIndex));
        }

        private void skipToStartOfCodeSequence()
        {
            if (mode == "text")
            {
                JObject startCommand = (JObject)theList[listIndex];
                JValue startCommandCode = (JValue)startCommand["code"];
                double codeNum = startCommandCode.ToObject<double>();
                while (codeNum == 401)
                {
                    JObject command = (JObject)theList[listIndex];
                    JValue commandCode = (JValue)command["code"];
                    codeNum = commandCode.ToObject<double>();
                    if (codeNum == 401)
                    {
                        listIndex--;
                    }
                    else
                    {
                        listIndex++; // we're at the 101 now, so one forward would be the top of the sequence
                    }
                }
            }
        }

        private void skipToEndOfCodeSequence()
        {
            if (mode == "text")
            {
                JObject startCommand = (JObject)theList[listIndex];
                JValue startCommandCode = (JValue)startCommand["code"];
                double codeNum = startCommandCode.ToObject<double>();
                while (codeNum == 401)
                {
                    JObject command = (JObject)theList[listIndex];
                    JValue commandCode = (JValue)command["code"];
                    codeNum = commandCode.ToObject<double>();
                    if (codeNum == 401)
                    {
                        listIndex++;
                    }
                }
            }
        }

        private bool searchDownForEventText()
        {
            int oldEventIndex = eventIndex;
            int oldPageIndex = pageIndex;
            int oldListIndex = listIndex;

            bool weFoundOne = false;
            skipToEndOfCodeSequence();
            do
            {
                listIndex++;
                if (listIndex >= theList.Count)
                {
                    listIndex = 0;
                    pageIndex++;
                }
                if (pageIndex >= thePages.Count)
                {
                    pageIndex = 0;
                    eventIndex++;
                    if (!(eventIndex >= mapEvents.Count))
                    {
                        JToken tempEvent = mapEvents[eventIndex];
                        while (tempEvent.Type == JTokenType.Null && !(eventIndex >= mapEvents.Count))
                        {
                            eventIndex++;
                            tempEvent = mapEvents[eventIndex];
                        }
                    }
                }
                if (eventIndex >= mapEvents.Count)
                {
                    eventIndex = oldEventIndex;
                    pageIndex = oldPageIndex;
                    listIndex = oldListIndex;
                    reloadEventsUpToList();
                    return false; //we're done.
                }
                reloadEventsUpToList();
                // now here the list should be valid, so we can start looking for text.
                JObject command = (JObject)theList[listIndex];
                JValue commandCode = (JValue)command["code"];
                double codeNum = commandCode.ToObject<double>();
                if (codeNum == 401)
                {
                    mode = "text";
                    currentEventText = BuildTextOutOfCode401s();
                    weFoundOne = true;
                }
            }
            while (!weFoundOne);
            return weFoundOne;
        }

        private bool searchUpForEventText()
        {
            int oldEventIndex = eventIndex;
            int oldPageIndex = pageIndex;
            int oldListIndex = listIndex;

            bool weFoundOne = false;
            skipToStartOfCodeSequence();
            do
            {
                listIndex--;
                if (listIndex < 0)
                {
                    listIndex = int.MaxValue;
                    pageIndex--;
                }
                if (pageIndex < 0 )
                {
                    pageIndex = int.MaxValue;
                    eventIndex--;
                    if (!(eventIndex >= mapEvents.Count))
                    {
                        JToken tempEvent = mapEvents[eventIndex];
                        while (tempEvent.Type == JTokenType.Null && !(eventIndex < 1))
                        {
                            eventIndex--;
                            tempEvent = mapEvents[eventIndex];
                        }
                    }
                }
                if (eventIndex < 1)
                {
                    eventIndex = oldEventIndex;
                    pageIndex = oldPageIndex;
                    listIndex = oldListIndex;
                    reloadEventsUpToList();
                    return false; //we're done.
                }
                reloadEventsUpToList();
                // now here the list should be valid, so we can start looking for text.
                JObject command = (JObject)theList[listIndex];
                JValue commandCode = (JValue)command["code"];
                double codeNum = commandCode.ToObject<double>();
                if (codeNum == 401)
                {
                    skipToStartOfCodeSequence();
                    mode = "text";
                    currentEventText = BuildTextOutOfCode401s();
                    weFoundOne = true;
                }
            }
            while (!weFoundOne);
            return weFoundOne;
        }


        private string BuildTextOutOfCode401s()
        {
            string lines = "";
            // so what we'll do is just keep gabbing lines until we see another code than 401.
            // when putting them back we'll have to count and add extra ones if someone inserted text,
            int tempListIndex = listIndex;
            JObject startCommand = (JObject)theList[listIndex];
            JValue startCommandCode = (JValue)startCommand["code"];
            double codeNum = startCommandCode.ToObject<double>();
            while (codeNum == 401)
            {
                JObject command = (JObject)theList[tempListIndex];
                JValue commandCode = (JValue)command["code"];
                codeNum = commandCode.ToObject<double>();
                if (codeNum == 401)
                {
                    JArray textLines = (JArray)command["parameters"];
                    if (textLines.Count != 1) { throw new ArgumentOutOfRangeException("I thought code 401s had only one line of text per parameter... Send me your map"); }
                    lines += ((JValue)textLines[0]).ToObject<string>() + "\n";
                }
                else
                {
                    return lines.TrimEnd(new[] { '\n' });
                }
                tempListIndex++;
            }
            return lines.TrimEnd(new[] { '\n' });
        }

        private void SaveTextDataToEvent(string text)
        {
            JObject special401Comamnd = (JObject)theList[listIndex].DeepClone();

            int tempListIndex = listIndex;
            string[] lines = text.Split(new[] { "\n" }, StringSplitOptions.None);
            if (mode == "text")
            {
                foreach (string line in lines)
                {
                    JObject command = (JObject)theList[tempListIndex];
                    JValue commandCode = (JValue)command["code"];
                    double codeNum = commandCode.ToObject<double>();
                    if (codeNum == 401)
                    {
                        JArray textParam = (JArray)command["parameters"];
                        textParam.Clear();
                        textParam.Add(line);
                    }
                    else
                    {
                        // TODO test I have no idea if this works.
                        JObject newCommand = (JObject)special401Comamnd.DeepClone();
                        JArray textParam = (JArray)newCommand["parameters"];
                        textParam.Clear();
                        textParam.Add(line);
                        command.AddBeforeSelf(newCommand);
                    }
                    tempListIndex++;
                }

                /*
                JObject command = (JObject)theList[listIndex];
                JArray textLines = (JArray)command["parameters"];
                textLines.Clear();
                foreach(string line in lines)
                {
                    textLines.Add(line);
                }
                */
            }
        }


        // ui stuff

        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            switch (keys)
            {
                case Keys.Up | Keys.Control:
                    Button_Previous_Click(Button_Next, new EventArgs());
                    return true; 
                case Keys.Down | Keys.Control:
                    Button_Next_Click(Button_Next, new EventArgs());
                    return true;
                case Keys.S | Keys.Control:
                    Button_Save_Click(Button_Save, new EventArgs());
                    return true;
                case Keys.O | Keys.Control:
                    Button_LoadMapFile_Click(Button_LoadMapFile, new EventArgs());
                    return true;
                case Keys.D | Keys.Control:
                    Button_CheckSpelling_Click(Button_CheckSpelling, new EventArgs());
                    return true;
            }

            // run base implementation
            return base.ProcessCmdKey(ref message, keys);
        }

        private void Button_LoadMapFile_Click(object sender, EventArgs e)
        {
            if (OFD_MapJson.ShowDialog() == DialogResult.OK)
            {
                string fileName = OFD_MapJson.FileName;
                // todo verify its actually a MapXXX file. 
                try
                {
                    TextBox_FileName.Text = fileName;
                    WarnAboutFileIfMV();
                    using (StreamReader file = File.OpenText(fileName))
                    using (JsonTextReader reader = new JsonTextReader(file))
                    {
                        mapObject = (JObject)JToken.ReadFrom(reader);
                    }

                    slurpDataFromMap();
                    reloadEventsUpToList();
                    bool didFindText = searchDownForEventText();
                    if (didFindText)
                    {
                        UpdateRTB();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured; the error was:\n" + ex.Message);
                }
            }

            if (CheckBox_AutoCheckSpelling.Checked)
            {
                CheckSpelling();
            }
        }

        private void WarnAboutFileIfMV()
        {
            //try to find Game.rpgproject. if it exists we want to warn the user about leaving Maker MV open.
            string fileName = TextBox_FileName.Text;

            try
            {
                string path = Path.GetDirectoryName(fileName);
                DirectoryInfo parentDir = Directory.GetParent(path);
                if (!alreadyWarnedAboutMV && File.Exists(parentDir.FullName + Path.DirectorySeparatorChar + "Game.rpgproject"))
                {
                    string programName = this.Text;
                    MessageBox.Show("Remember! You must close RPG Maker MV while spell checking to avoid data loss. Make sure the RPG Maker MV program is closed.\n\nYou won't be warned again until you restart " + programName, "MV Data Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    alreadyWarnedAboutMV = true;
                }
            }
            catch
            {
                //if we couldn't find the Game.rpgproject then we probably don't need to warn them.
            }
        }


        private void Button_Next_Click(object sender, EventArgs e)
        {
            if (mapObject == null) { return; }
            SaveTextDataToEvent(RTB_EventText.Text);
            bool didFindText = searchDownForEventText();
            if (didFindText)
            {
                UpdateRTB();
            }
            if (CheckBox_AutoCheckSpelling.Checked)
            {
                CheckSpelling();
            }
        }

        private void Button_Previous_Click(object sender, EventArgs e)
        {
            if (mapObject == null) { return; }
            SaveTextDataToEvent(RTB_EventText.Text);
            bool didFindText = searchUpForEventText();
            if (didFindText)
            {
                UpdateRTB();
            }
            if (CheckBox_AutoCheckSpelling.Checked)
            {
                CheckSpelling();
            }
        }

        private void Button_SaveAs_Click(object sender, EventArgs e)
        {
            if (mapObject == null) { return; }
            if (SFD_MapJson.ShowDialog() == DialogResult.OK)
            {
                string fileName = SFD_MapJson.FileName;
                DoSave(fileName);
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (mapObject == null) { return; }
            bool itWorked = DoSave(TextBox_FileName.Text);
            if (itWorked)
            {
                Button_Save.Text = "Saved!!!!";
                timer_ShowSavedtext.Start();
            }

        }

        private bool DoSave(string fileName)
        {
            try
            {
                if (fileName != "")
                {
                    using (StreamWriter file = File.CreateText(fileName))
                    using (JsonTextWriter writer = new JsonTextWriter(file))
                    {
                        mapObject.WriteTo(writer);
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("File was not saved! Filename was empty", "Save Error");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured while saving; the error was:\n" + ex.Message);
                return false;
            }
        }

            private void Button_CheckSpelling_Click(object sender, EventArgs e)
        {
            CheckSpelling();
        }

        private void CheckBox_AutoCheckSpelling_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_AutoCheckSpelling.Checked)
            {
                CheckSpelling();
            }
        }

        private void Timer_CheckSpelling_Tick(object sender, EventArgs e)
        {
            Timer_CheckSpelling.Stop();
            if (!CheckBox_AutoCheckSpelling.Checked)
            {
                // if we're not auto-spelling then the user must have manually opened the window.
                NHunspellWrapper.Instance.ShowCheckAllWindow();
            }
            else if (NHunspellWrapper.Instance.GetMisspelledWordsRanges().Count > 0)
            {
                NHunspellWrapper.Instance.ShowCheckAllWindow();
            }
        }

        private void TextBox_FileName_TextChanged(object sender, EventArgs e)
        {
            loadedFileName = Path.GetFileName(TextBox_FileName.Text);
            Button_Save.Text = "Save " + loadedFileName;
        }

        private void timer_ShowSavedtext_Tick(object sender, EventArgs e)
        {
            timer_ShowSavedtext.Stop();
            Button_Save.Text = "Save " + loadedFileName;
        }

        private void RTB_EventText_SelectionChanged(object sender, EventArgs e)
        {
            UpdateRTBFeatureButtons();
        }

        private void RTB_EventText_TextChanged(object sender, EventArgs e)
        {
            UpdateRTBFeatureButtons();
        }

        private void UpdateRTBFeatureButtons()
        {
            Button_Undo.Enabled = !RTB_EventText.ReadOnly && RTB_EventText.CanUndo;
            Button_Redo.Enabled = !RTB_EventText.ReadOnly && RTB_EventText.CanRedo;
            Button_Cut.Enabled = !RTB_EventText.ReadOnly && RTB_EventText.SelectionLength > 0;
            Button_Copy.Enabled = RTB_EventText.SelectionLength > 0;
            Button_Paste.Enabled = !RTB_EventText.ReadOnly && Clipboard.ContainsText();
            Button_SelectAll.Enabled = RTB_EventText.TextLength > 0 && RTB_EventText.SelectionLength < RTB_EventText.TextLength;
        }

        private void Button_Copy_Click(object sender, EventArgs e)
        {
            RTB_EventText.Focus();
            RTB_EventText.Copy();
            UpdateRTBFeatureButtons();
        }

        private void Button_Paste_Click(object sender, EventArgs e)
        {
            RTB_EventText.Focus();
            RTB_EventText.Paste();
            UpdateRTBFeatureButtons();
        }

        private void Button_SelectAll_Click(object sender, EventArgs e)
        {
            RTB_EventText.Focus();
             RTB_EventText.SelectAll();
            UpdateRTBFeatureButtons();
        }

        private void Button_Undo_Click(object sender, EventArgs e)
        {
            RTB_EventText.Focus();
            RTB_EventText.Undo();
            UpdateRTBFeatureButtons();
        }

        private void Button_Redo_Click(object sender, EventArgs e)
        {
            RTB_EventText.Focus();
            RTB_EventText.Redo();
            UpdateRTBFeatureButtons();
        }

        private void VLabel_MouseScroll_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                Button_Next_Click(Button_Next, new EventArgs());
            }
            else if (e.Delta > 0)
            {
                Button_Previous_Click(Button_Previous, new EventArgs());
            }
        }
    }
}
