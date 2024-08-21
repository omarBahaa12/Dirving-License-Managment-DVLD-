using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_UITier.UserControls
{
    public partial class UCTakeTest : UserControl
    {
        public bool IsSetResult {  get; private set; }
        public bool Result {  get; private set; }
        public string Notes {  get; private set; }
        public UCTakeTest()
        {
            InitializeComponent();
        }
        private void Rdbtn_Success_CheckedChanged(object sender, EventArgs e)
        {
            Result = true;
            IsSetResult = true;
        }
        private void Rdbtn_Failed_CheckedChanged(object sender, EventArgs e)
        {
            Result = false;
            IsSetResult = true;
        }
        private void TXtb_Notes_TextChanged(object sender, EventArgs e)
        {
            Notes = TXtb_Notes.Text;
        }
    }
}
