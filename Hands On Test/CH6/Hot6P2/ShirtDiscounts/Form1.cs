using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShirtDiscounts
{
    public partial class Form1 : Form
    {
        int[] codes = { 8264, 5679, 6483 };
        float[] discountPercents = { .3f, .2f, .1f };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            float discountPercent = CheckDiscountCode(txtCode.Text);
           
            if(discountPercent == -1)
            {
                //no discount
            }
            else
            {
                //discount
            }

        }

        private float CheckDiscountCode(string discountCode)
        {
           float discountPercent = -1;
           float code;
           float.TryParse(discountCode, out code);

            for (int i = 0; i < codes.Length; i++)
            {
                if(code == codes[i])
                {
                    discountPercent = discountPercents[i];
                }
            }
            return discountPercent;
        }

        private void ShowInvoice(int qty, float discountPercent)
        {

        }
    }
}
