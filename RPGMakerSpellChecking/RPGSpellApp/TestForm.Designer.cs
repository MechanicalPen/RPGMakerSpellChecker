namespace TestingApplication
{
   partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.bCkeckAll = new System.Windows.Forms.Button();
            this.chAutoSpelling = new System.Windows.Forms.CheckBox();
            this.customPaintRichText21 = new TestingApplication.CustomPaintRichText();
            this.customMaskedTextBox1 = new TestingApplication.CustomMaskedTextBox();
            this.spellingWorker1 = new NHunspellComponent.Spelling.SpellingWorker();
            this.spellingWorker2 = new NHunspellComponent.Spelling.SpellingWorker();
            this.SuspendLayout();
            // 
            // bCkeckAll
            // 
            this.bCkeckAll.Location = new System.Drawing.Point(12, 12);
            this.bCkeckAll.Name = "bCkeckAll";
            this.bCkeckAll.Size = new System.Drawing.Size(75, 23);
            this.bCkeckAll.TabIndex = 9;
            this.bCkeckAll.Text = "Check All";
            this.bCkeckAll.UseVisualStyleBackColor = true;
            this.bCkeckAll.Click += new System.EventHandler(this.bCkeckAll_Click);
            // 
            // chAutoSpelling
            // 
            this.chAutoSpelling.AutoSize = true;
            this.chAutoSpelling.Checked = true;
            this.chAutoSpelling.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chAutoSpelling.Location = new System.Drawing.Point(93, 16);
            this.chAutoSpelling.Name = "chAutoSpelling";
            this.chAutoSpelling.Size = new System.Drawing.Size(85, 17);
            this.chAutoSpelling.TabIndex = 10;
            this.chAutoSpelling.Text = "AutoSpelling";
            this.chAutoSpelling.UseVisualStyleBackColor = true;
            this.chAutoSpelling.CheckedChanged += new System.EventHandler(this.chAutoSpelling_CheckedChanged);
            // 
            // customPaintRichText21
            // 
            this.customPaintRichText21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPaintRichText21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customPaintRichText21.IsPassWordProtected = false;
            this.customPaintRichText21.IsSpellingAutoEnabled = true;
            this.customPaintRichText21.IsSpellingEnabled = true;
            this.customPaintRichText21.Location = new System.Drawing.Point(12, 41);
            this.customPaintRichText21.Name = "customPaintRichText21";
            this.customPaintRichText21.Size = new System.Drawing.Size(360, 159);
            this.customPaintRichText21.TabIndex = 14;
            this.customPaintRichText21.Text = resources.GetString("customPaintRichText21.Text");
            this.customPaintRichText21.UnderlinedSections = ((System.Collections.Generic.Dictionary<int, int>)(resources.GetObject("customPaintRichText21.UnderlinedSections")));
            // 
            // customMaskedTextBox1
            // 
            this.customMaskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customMaskedTextBox1.IsPassWordProtected = false;
            this.customMaskedTextBox1.IsSpellingAutoEnabled = false;
            this.customMaskedTextBox1.IsSpellingEnabled = true;
            this.customMaskedTextBox1.Location = new System.Drawing.Point(184, 12);
            this.customMaskedTextBox1.Name = "customMaskedTextBox1";
            this.customMaskedTextBox1.Size = new System.Drawing.Size(188, 20);
            this.customMaskedTextBox1.TabIndex = 11;
            // 
            // spellingWorker1
            // 
            this.spellingWorker1.Editor = this.customPaintRichText21;
            // 
            // spellingWorker2
            // 
            this.spellingWorker2.Editor = this.customMaskedTextBox1;
            this.spellingWorker2.IsEditorSpellingAutoEnabled = false;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Controls.Add(this.customPaintRichText21);
            this.Controls.Add(this.customMaskedTextBox1);
            this.Controls.Add(this.chAutoSpelling);
            this.Controls.Add(this.bCkeckAll);
            this.Name = "TestForm";
            this.Text = "Test Application";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button bCkeckAll;
      private System.Windows.Forms.CheckBox chAutoSpelling;
      private CustomMaskedTextBox customMaskedTextBox1;
      private CustomPaintRichText customPaintRichText21;
      private NHunspellComponent.Spelling.SpellingWorker spellingWorker1;
      private NHunspellComponent.Spelling.SpellingWorker spellingWorker2;
   }
}

