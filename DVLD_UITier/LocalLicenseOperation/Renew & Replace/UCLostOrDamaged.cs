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
    public partial class UCLostOrDamaged : UserControl
    {
        public delegate void FinishCheck(short Reason);
        public event FinishCheck OnFinishCheck;
        public UCLostOrDamaged()
        {
            InitializeComponent();
        }

        private void RdBtn_Damaged_CheckedChanged(object sender, EventArgs e)
        {
            OnFinishCheck?.Invoke(4);
        }

        private void RdBtn_Lost_CheckedChanged(object sender, EventArgs e)
        {
            OnFinishCheck?.Invoke(3);
        }
    }
}
