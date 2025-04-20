
namespace RPGMakerSpellChecker
{
    partial class Form_RPGMakerSpellCheck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RPGMakerSpellCheck));
            this.OFD_MapJson = new System.Windows.Forms.OpenFileDialog();
            this.Button_LoadMapFile = new System.Windows.Forms.Button();
            this.TextBox_FileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Backup = new System.Windows.Forms.Label();
            this.Button_SaveAs = new System.Windows.Forms.Button();
            this.Button_Previous = new System.Windows.Forms.Button();
            this.Button_Next = new System.Windows.Forms.Button();
            this.SFD_MapJson = new System.Windows.Forms.SaveFileDialog();
            this.Button_CheckSpelling = new System.Windows.Forms.Button();
            this.CheckBox_AutoCheckSpelling = new System.Windows.Forms.CheckBox();
            this.Timer_CheckSpelling = new System.Windows.Forms.Timer(this.components);
            this.Button_Save = new System.Windows.Forms.Button();
            this.timer_ShowSavedtext = new System.Windows.Forms.Timer(this.components);
            this.Label_EventLabel = new System.Windows.Forms.Label();
            this.Label_Event = new System.Windows.Forms.Label();
            this.Label_PageLabel = new System.Windows.Forms.Label();
            this.Label_Page = new System.Windows.Forms.Label();
            this.RTB_EventText = new RPGMakerSpellChecker.CustomPaintRichText();
            this.spellingWorker1 = new NHunspellComponent.Spelling.SpellingWorker();
            this.Label_EventNameLabel = new System.Windows.Forms.Label();
            this.Label_EventName = new System.Windows.Forms.Label();
            this.Button_Copy = new System.Windows.Forms.Button();
            this.Button_Paste = new System.Windows.Forms.Button();
            this.Button_SelectAll = new System.Windows.Forms.Button();
            this.Button_Undo = new System.Windows.Forms.Button();
            this.Button_Redo = new System.Windows.Forms.Button();
            this.Button_Cut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OFD_MapJson
            // 
            this.OFD_MapJson.FileName = "Map001.json";
            this.OFD_MapJson.Filter = "RPG Maker Map Files|*.json";
            this.OFD_MapJson.Title = "Select a Map file to spell check";
            // 
            // Button_LoadMapFile
            // 
            this.Button_LoadMapFile.Location = new System.Drawing.Point(12, 12);
            this.Button_LoadMapFile.Name = "Button_LoadMapFile";
            this.Button_LoadMapFile.Size = new System.Drawing.Size(119, 23);
            this.Button_LoadMapFile.TabIndex = 0;
            this.Button_LoadMapFile.Text = "Open MapXXX.json";
            this.Button_LoadMapFile.UseVisualStyleBackColor = true;
            this.Button_LoadMapFile.Click += new System.EventHandler(this.Button_LoadMapFile_Click);
            // 
            // TextBox_FileName
            // 
            this.TextBox_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_FileName.Location = new System.Drawing.Point(228, 12);
            this.TextBox_FileName.Name = "TextBox_FileName";
            this.TextBox_FileName.ReadOnly = true;
            this.TextBox_FileName.Size = new System.Drawing.Size(544, 20);
            this.TextBox_FileName.TabIndex = 2;
            this.TextBox_FileName.TextChanged += new System.EventHandler(this.TextBox_FileName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Map Loaded:";
            // 
            // Label_Backup
            // 
            this.Label_Backup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Backup.AutoSize = true;
            this.Label_Backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Backup.Location = new System.Drawing.Point(617, 268);
            this.Label_Backup.Name = "Label_Backup";
            this.Label_Backup.Size = new System.Drawing.Size(155, 13);
            this.Label_Backup.TabIndex = 12;
            this.Label_Backup.Text = "(Did you back up your project?)";
            // 
            // Button_SaveAs
            // 
            this.Button_SaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SaveAs.Location = new System.Drawing.Point(691, 284);
            this.Button_SaveAs.Name = "Button_SaveAs";
            this.Button_SaveAs.Size = new System.Drawing.Size(81, 23);
            this.Button_SaveAs.TabIndex = 14;
            this.Button_SaveAs.Text = "Save As...";
            this.Button_SaveAs.UseVisualStyleBackColor = true;
            this.Button_SaveAs.Click += new System.EventHandler(this.Button_SaveAs_Click);
            // 
            // Button_Previous
            // 
            this.Button_Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Previous.Location = new System.Drawing.Point(673, 56);
            this.Button_Previous.Name = "Button_Previous";
            this.Button_Previous.Size = new System.Drawing.Size(99, 23);
            this.Button_Previous.TabIndex = 3;
            this.Button_Previous.Text = "Previous Text";
            this.Button_Previous.UseVisualStyleBackColor = true;
            this.Button_Previous.Click += new System.EventHandler(this.Button_Previous_Click);
            // 
            // Button_Next
            // 
            this.Button_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Next.Location = new System.Drawing.Point(673, 187);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(99, 23);
            this.Button_Next.TabIndex = 11;
            this.Button_Next.Text = "Next Text";
            this.Button_Next.UseVisualStyleBackColor = true;
            this.Button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // SFD_MapJson
            // 
            this.SFD_MapJson.Filter = "RPG Maker Map Files|*.json";
            this.SFD_MapJson.Title = "Save the Map File";
            // 
            // Button_CheckSpelling
            // 
            this.Button_CheckSpelling.Location = new System.Drawing.Point(12, 56);
            this.Button_CheckSpelling.Name = "Button_CheckSpelling";
            this.Button_CheckSpelling.Size = new System.Drawing.Size(99, 23);
            this.Button_CheckSpelling.TabIndex = 8;
            this.Button_CheckSpelling.Text = "Check Spelling";
            this.Button_CheckSpelling.UseVisualStyleBackColor = true;
            this.Button_CheckSpelling.Click += new System.EventHandler(this.Button_CheckSpelling_Click);
            // 
            // CheckBox_AutoCheckSpelling
            // 
            this.CheckBox_AutoCheckSpelling.AutoSize = true;
            this.CheckBox_AutoCheckSpelling.Location = new System.Drawing.Point(120, 60);
            this.CheckBox_AutoCheckSpelling.Name = "CheckBox_AutoCheckSpelling";
            this.CheckBox_AutoCheckSpelling.Size = new System.Drawing.Size(81, 17);
            this.CheckBox_AutoCheckSpelling.TabIndex = 9;
            this.CheckBox_AutoCheckSpelling.Text = "Auto-check";
            this.CheckBox_AutoCheckSpelling.UseVisualStyleBackColor = true;
            this.CheckBox_AutoCheckSpelling.CheckedChanged += new System.EventHandler(this.CheckBox_AutoCheckSpelling_CheckedChanged);
            // 
            // Timer_CheckSpelling
            // 
            this.Timer_CheckSpelling.Interval = 150;
            this.Timer_CheckSpelling.Tick += new System.EventHandler(this.Timer_CheckSpelling_Tick);
            // 
            // Button_Save
            // 
            this.Button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Save.Location = new System.Drawing.Point(563, 284);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(119, 23);
            this.Button_Save.TabIndex = 13;
            this.Button_Save.Text = "Save MapXXX.json";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // timer_ShowSavedtext
            // 
            this.timer_ShowSavedtext.Interval = 3000;
            this.timer_ShowSavedtext.Tick += new System.EventHandler(this.timer_ShowSavedtext_Tick);
            // 
            // Label_EventLabel
            // 
            this.Label_EventLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_EventLabel.AutoSize = true;
            this.Label_EventLabel.Location = new System.Drawing.Point(298, 61);
            this.Label_EventLabel.Name = "Label_EventLabel";
            this.Label_EventLabel.Size = new System.Drawing.Size(52, 13);
            this.Label_EventLabel.TabIndex = 4;
            this.Label_EventLabel.Text = "Event ID:";
            // 
            // Label_Event
            // 
            this.Label_Event.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Event.AutoSize = true;
            this.Label_Event.Location = new System.Drawing.Point(351, 61);
            this.Label_Event.Name = "Label_Event";
            this.Label_Event.Size = new System.Drawing.Size(39, 13);
            this.Label_Event.TabIndex = 5;
            this.Label_Event.Text = "EV000";
            // 
            // Label_PageLabel
            // 
            this.Label_PageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_PageLabel.AutoSize = true;
            this.Label_PageLabel.Location = new System.Drawing.Point(406, 61);
            this.Label_PageLabel.Name = "Label_PageLabel";
            this.Label_PageLabel.Size = new System.Drawing.Size(35, 13);
            this.Label_PageLabel.TabIndex = 6;
            this.Label_PageLabel.Text = "Page:";
            // 
            // Label_Page
            // 
            this.Label_Page.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Page.AutoSize = true;
            this.Label_Page.Location = new System.Drawing.Point(442, 61);
            this.Label_Page.Name = "Label_Page";
            this.Label_Page.Size = new System.Drawing.Size(13, 13);
            this.Label_Page.TabIndex = 7;
            this.Label_Page.Text = "0";
            // 
            // RTB_EventText
            // 
            this.RTB_EventText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_EventText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_EventText.IsPassWordProtected = false;
            this.RTB_EventText.IsSpellingAutoEnabled = false;
            this.RTB_EventText.IsSpellingEnabled = false;
            this.RTB_EventText.Location = new System.Drawing.Point(12, 85);
            this.RTB_EventText.Name = "RTB_EventText";
            this.RTB_EventText.Size = new System.Drawing.Size(760, 96);
            this.RTB_EventText.TabIndex = 10;
            this.RTB_EventText.Text = "";
            this.RTB_EventText.UnderlinedSections = ((System.Collections.Generic.Dictionary<int, int>)(resources.GetObject("RTB_EventText.UnderlinedSections")));
            this.RTB_EventText.SelectionChanged += new System.EventHandler(this.RTB_EventText_SelectionChanged);
            this.RTB_EventText.TextChanged += new System.EventHandler(this.RTB_EventText_TextChanged);
            this.RTB_EventText.Enter += new System.EventHandler(this.RTB_EventText_Enter);
            this.RTB_EventText.Leave += new System.EventHandler(this.RTB_EventText_Leave);
            // 
            // spellingWorker1
            // 
            this.spellingWorker1.Editor = this.RTB_EventText;
            this.spellingWorker1.IsEditorSpellingAutoEnabled = false;
            this.spellingWorker1.IsEditorSpellingEnabled = false;
            // 
            // Label_EventNameLabel
            // 
            this.Label_EventNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_EventNameLabel.AutoSize = true;
            this.Label_EventNameLabel.Location = new System.Drawing.Point(473, 61);
            this.Label_EventNameLabel.Name = "Label_EventNameLabel";
            this.Label_EventNameLabel.Size = new System.Drawing.Size(38, 13);
            this.Label_EventNameLabel.TabIndex = 15;
            this.Label_EventNameLabel.Text = "Name:";
            // 
            // Label_EventName
            // 
            this.Label_EventName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_EventName.AutoSize = true;
            this.Label_EventName.Location = new System.Drawing.Point(512, 61);
            this.Label_EventName.Name = "Label_EventName";
            this.Label_EventName.Size = new System.Drawing.Size(39, 13);
            this.Label_EventName.TabIndex = 16;
            this.Label_EventName.Text = "EV000";
            // 
            // Button_Copy
            // 
            this.Button_Copy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_Copy.Location = new System.Drawing.Point(355, 216);
            this.Button_Copy.Name = "Button_Copy";
            this.Button_Copy.Size = new System.Drawing.Size(75, 23);
            this.Button_Copy.TabIndex = 17;
            this.Button_Copy.Text = "Copy";
            this.Button_Copy.UseVisualStyleBackColor = true;
            this.Button_Copy.Click += new System.EventHandler(this.Button_Copy_Click);
            // 
            // Button_Paste
            // 
            this.Button_Paste.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_Paste.Location = new System.Drawing.Point(355, 245);
            this.Button_Paste.Name = "Button_Paste";
            this.Button_Paste.Size = new System.Drawing.Size(75, 23);
            this.Button_Paste.TabIndex = 18;
            this.Button_Paste.Text = "Paste";
            this.Button_Paste.UseVisualStyleBackColor = true;
            this.Button_Paste.Click += new System.EventHandler(this.Button_Paste_Click);
            // 
            // Button_SelectAll
            // 
            this.Button_SelectAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_SelectAll.Location = new System.Drawing.Point(355, 274);
            this.Button_SelectAll.Name = "Button_SelectAll";
            this.Button_SelectAll.Size = new System.Drawing.Size(75, 23);
            this.Button_SelectAll.TabIndex = 19;
            this.Button_SelectAll.Text = "Select All";
            this.Button_SelectAll.UseVisualStyleBackColor = true;
            this.Button_SelectAll.Click += new System.EventHandler(this.Button_SelectAll_Click);
            // 
            // Button_Undo
            // 
            this.Button_Undo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_Undo.Location = new System.Drawing.Point(209, 214);
            this.Button_Undo.Name = "Button_Undo";
            this.Button_Undo.Size = new System.Drawing.Size(75, 23);
            this.Button_Undo.TabIndex = 20;
            this.Button_Undo.Text = "Undo";
            this.Button_Undo.UseVisualStyleBackColor = true;
            this.Button_Undo.Click += new System.EventHandler(this.Button_Undo_Click);
            // 
            // Button_Redo
            // 
            this.Button_Redo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_Redo.Location = new System.Drawing.Point(501, 214);
            this.Button_Redo.Name = "Button_Redo";
            this.Button_Redo.Size = new System.Drawing.Size(75, 23);
            this.Button_Redo.TabIndex = 21;
            this.Button_Redo.Text = "Redo";
            this.Button_Redo.UseVisualStyleBackColor = true;
            this.Button_Redo.Click += new System.EventHandler(this.Button_Redo_Click);
            // 
            // Button_Cut
            // 
            this.Button_Cut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_Cut.Location = new System.Drawing.Point(355, 187);
            this.Button_Cut.Name = "Button_Cut";
            this.Button_Cut.Size = new System.Drawing.Size(75, 23);
            this.Button_Cut.TabIndex = 22;
            this.Button_Cut.Text = "Cut";
            this.Button_Cut.UseVisualStyleBackColor = true;
            // 
            // Form_RPGMakerSpellCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 319);
            this.Controls.Add(this.Button_Cut);
            this.Controls.Add(this.Button_Redo);
            this.Controls.Add(this.Button_Undo);
            this.Controls.Add(this.Button_SelectAll);
            this.Controls.Add(this.Button_Paste);
            this.Controls.Add(this.Button_Copy);
            this.Controls.Add(this.Label_EventNameLabel);
            this.Controls.Add(this.Label_EventName);
            this.Controls.Add(this.Label_PageLabel);
            this.Controls.Add(this.Label_EventLabel);
            this.Controls.Add(this.Label_Page);
            this.Controls.Add(this.Label_Event);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.CheckBox_AutoCheckSpelling);
            this.Controls.Add(this.Button_CheckSpelling);
            this.Controls.Add(this.Button_Next);
            this.Controls.Add(this.Button_Previous);
            this.Controls.Add(this.RTB_EventText);
            this.Controls.Add(this.Button_SaveAs);
            this.Controls.Add(this.Label_Backup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_FileName);
            this.Controls.Add(this.Button_LoadMapFile);
            this.Name = "Form_RPGMakerSpellCheck";
            this.Text = "RPG Maker MV/MZ Spell Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OFD_MapJson;
        private System.Windows.Forms.Button Button_LoadMapFile;
        private System.Windows.Forms.TextBox TextBox_FileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Backup;
        private System.Windows.Forms.Button Button_SaveAs;
        private CustomPaintRichText RTB_EventText;
        private System.Windows.Forms.Button Button_Previous;
        private System.Windows.Forms.Button Button_Next;
        private System.Windows.Forms.SaveFileDialog SFD_MapJson;
        private NHunspellComponent.Spelling.SpellingWorker spellingWorker1;
        private System.Windows.Forms.Button Button_CheckSpelling;
        private System.Windows.Forms.CheckBox CheckBox_AutoCheckSpelling;
        private System.Windows.Forms.Timer Timer_CheckSpelling;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Timer timer_ShowSavedtext;
        private System.Windows.Forms.Label Label_EventLabel;
        private System.Windows.Forms.Label Label_Event;
        private System.Windows.Forms.Label Label_PageLabel;
        private System.Windows.Forms.Label Label_Page;
        private System.Windows.Forms.Label Label_EventNameLabel;
        private System.Windows.Forms.Label Label_EventName;
        private System.Windows.Forms.Button Button_Copy;
        private System.Windows.Forms.Button Button_Paste;
        private System.Windows.Forms.Button Button_SelectAll;
        private System.Windows.Forms.Button Button_Undo;
        private System.Windows.Forms.Button Button_Redo;
        private System.Windows.Forms.Button Button_Cut;
    }
}