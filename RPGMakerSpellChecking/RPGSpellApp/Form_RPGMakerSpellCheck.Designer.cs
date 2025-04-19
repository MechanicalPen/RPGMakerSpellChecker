
namespace TestingApplication
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
            this.RTB_EventText = new TestingApplication.CustomPaintRichText();
            this.spellingWorker1 = new NHunspellComponent.Spelling.SpellingWorker();
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
            this.TextBox_FileName.Size = new System.Drawing.Size(525, 20);
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
            this.Label_Backup.Location = new System.Drawing.Point(598, 268);
            this.Label_Backup.Name = "Label_Backup";
            this.Label_Backup.Size = new System.Drawing.Size(155, 13);
            this.Label_Backup.TabIndex = 8;
            this.Label_Backup.Text = "(Did you back up yoru project?)";
            // 
            // Button_SaveAs
            // 
            this.Button_SaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SaveAs.Location = new System.Drawing.Point(672, 284);
            this.Button_SaveAs.Name = "Button_SaveAs";
            this.Button_SaveAs.Size = new System.Drawing.Size(81, 23);
            this.Button_SaveAs.TabIndex = 10;
            this.Button_SaveAs.Text = "Save As...";
            this.Button_SaveAs.UseVisualStyleBackColor = true;
            this.Button_SaveAs.Click += new System.EventHandler(this.Button_SaveAs_Click);
            // 
            // Button_Previous
            // 
            this.Button_Previous.Location = new System.Drawing.Point(12, 74);
            this.Button_Previous.Name = "Button_Previous";
            this.Button_Previous.Size = new System.Drawing.Size(99, 23);
            this.Button_Previous.TabIndex = 3;
            this.Button_Previous.Text = "Previous Event";
            this.Button_Previous.UseVisualStyleBackColor = true;
            this.Button_Previous.Click += new System.EventHandler(this.Button_Previous_Click);
            // 
            // Button_Next
            // 
            this.Button_Next.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Button_Next.Location = new System.Drawing.Point(12, 205);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(99, 23);
            this.Button_Next.TabIndex = 7;
            this.Button_Next.Text = "Next Event";
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
            this.Button_CheckSpelling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_CheckSpelling.Location = new System.Drawing.Point(564, 74);
            this.Button_CheckSpelling.Name = "Button_CheckSpelling";
            this.Button_CheckSpelling.Size = new System.Drawing.Size(99, 23);
            this.Button_CheckSpelling.TabIndex = 4;
            this.Button_CheckSpelling.Text = "Check Spelling";
            this.Button_CheckSpelling.UseVisualStyleBackColor = true;
            this.Button_CheckSpelling.Click += new System.EventHandler(this.Button_CheckSpelling_Click);
            // 
            // CheckBox_AutoCheckSpelling
            // 
            this.CheckBox_AutoCheckSpelling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBox_AutoCheckSpelling.AutoSize = true;
            this.CheckBox_AutoCheckSpelling.Location = new System.Drawing.Point(672, 78);
            this.CheckBox_AutoCheckSpelling.Name = "CheckBox_AutoCheckSpelling";
            this.CheckBox_AutoCheckSpelling.Size = new System.Drawing.Size(81, 17);
            this.CheckBox_AutoCheckSpelling.TabIndex = 5;
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
            this.Button_Save.Location = new System.Drawing.Point(544, 284);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(119, 23);
            this.Button_Save.TabIndex = 9;
            this.Button_Save.Text = "Save MapXXX.json";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // timer_ShowSavedtext
            // 
            this.timer_ShowSavedtext.Interval = 3000;
            this.timer_ShowSavedtext.Tick += new System.EventHandler(this.timer_ShowSavedtext_Tick);
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
            this.RTB_EventText.Location = new System.Drawing.Point(12, 103);
            this.RTB_EventText.Name = "RTB_EventText";
            this.RTB_EventText.Size = new System.Drawing.Size(741, 96);
            this.RTB_EventText.TabIndex = 6;
            this.RTB_EventText.Text = "";
            this.RTB_EventText.UnderlinedSections = ((System.Collections.Generic.Dictionary<int, int>)(resources.GetObject("RTB_EventText.UnderlinedSections")));
            // 
            // spellingWorker1
            // 
            this.spellingWorker1.Editor = this.RTB_EventText;
            this.spellingWorker1.IsEditorSpellingAutoEnabled = false;
            this.spellingWorker1.IsEditorSpellingEnabled = false;
            // 
            // Form_RPGMakerSpellCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 319);
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
    }
}