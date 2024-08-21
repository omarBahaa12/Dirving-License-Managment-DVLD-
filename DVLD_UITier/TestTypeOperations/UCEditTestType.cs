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

namespace DVLD_UITier.UserControls
{
    public partial class UCEditTestType : UserControl
    {
        public string TestName {  get; set; }
        public string TestDescription { get; set; }
        public double Fees {  get; set; }
        public UCEditTestType()
        {
            InitializeComponent();
        }

        public void SetTestType(int ID)
        {
            clsTestsTypes testType = clsTestsTypes.TestTypes(ID);
            Textb_Fees.Texts=testType._Fees.ToString();
            TestDescription=Txtb_Description.Texts=testType._TestDescription;
            TestName=Txtb_TestName.Texts=testType._TestName;
            Fees=testType._Fees;
        }

        private void Txtb_TestName__TextChanged(object sender, EventArgs e)
        {
            TestName=Txtb_TestName.Texts;
        }

        private void Txtb_Description__TextChanged(object sender, EventArgs e)
        {
            TestDescription=Txtb_Description.Texts;
        }

        private void Textb_Fees__TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(Textb_Fees.Texts,out double value))
            {
                Fees=value;
            }
            else
            {
                Fees = 0;
                Textb_Fees.Focus();
                errorProvider1.SetError(Textb_Fees, "Enter Numbers");
            }
        }
     
    }
}
