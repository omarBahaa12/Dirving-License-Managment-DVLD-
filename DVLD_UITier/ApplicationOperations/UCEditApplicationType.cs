using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_UITier
{
    public partial class UCEditApplicationType : UserControl
    {
        public double Fees {  get; set; }

        public string Title {  get; set; }
        public UCEditApplicationType()
        {
            InitializeComponent();
        }
        
        public void SetApplicationData(int ApplicationID)
        {
            clsApplicationType Application=clsApplicationType.GetApplicationType(ApplicationID);
            if (Application != null)
            {
                Txtb_Title.Texts = Application._Title;
                TXtb_Fees.Texts=Application._Fees.ToString();
            }
        }

        private void TXtb_Fees__TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(TXtb_Fees.Texts,out double Value)&&!string.IsNullOrWhiteSpace(TXtb_Fees.Texts))
            {
                Fees = Value;
            }
            else
            {
                TXtb_Fees.Focus();
                errorProvider1.SetError(TXtb_Fees, "Enter Numbers");
            }
        }

        private void Txtb_Title__TextChanged(object sender, EventArgs e)
        {
            Title=Txtb_Title.Texts;
        }
    }
}
