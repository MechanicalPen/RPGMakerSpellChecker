using System;
using System.Windows.Forms;
using NHunspellComponent.Spelling;

namespace TestingApplication
{
   public partial class TestForm : Form
   {
      public TestForm()
      {
         InitializeComponent();
      }

      private void bCkeckAll_Click(object sender, EventArgs e)
      {
         NHunspellWrapper.Instance.ShowCheckAllWindow();
      }

      private void chAutoSpelling_CheckedChanged(object sender, EventArgs e)
      {
         customPaintRichText21.IsSpellingAutoEnabled = chAutoSpelling.Checked;
      }
   }
}