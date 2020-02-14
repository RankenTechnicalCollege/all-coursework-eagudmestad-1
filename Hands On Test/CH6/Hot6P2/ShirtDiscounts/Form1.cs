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
        string[] discountCodes = { "8264", "5679", "6483" };
        float[] discountPercents = { .3f, .2f, .1f };


        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
             float discountPercent = CheckDiscountCode(txtCode.Text);

            int qtyShirts = Convert.ToInt32(txtQty.Text);

            ShowInvoice(qtyShirts, discountPercent);

        }

        private float CheckDiscountCode(string discountCode)
        {
            string code = txtCode.Text;
            int discountIntCode;

            float discountPercent = -1;

            if(discountCode == "")
            {
                discountPercent = 0;
            }

            if(int.TryParse(code,out discountIntCode))
            {
                for (int i = 0; i < discountCodes.Length; i++)
                {
                    if(discountCodes[i].Equals(discountCode))
                    {
                        //match found
                        discountPercent = discountPercents[i];
                    }
                }     
            }
           
            return discountPercent;
        }

        private void ShowInvoice(int qtyShirts, float discountPercent)
        {
            double subtotal=0, tax=0, total=0;
            if(discountPercent == -1)
            {
                subtotal = qtyShirts * 13.75;
                tax = subtotal * .08;
                total = subtotal + tax;
                lblDiscount.Text = $"Invalid Discount Code";
            }
            else if(discountPercent == 0)
            {
                subtotal = qtyShirts * 13.75;
                tax = subtotal * .08;
                total = subtotal + tax;
                lblDiscount.Text = $"";
            }
            else
            {
                lblDiscount.Text = $"{discountPercent} applied";
                double pricePerShirt = Math.Round(13.75 * (1-discountPercent),2);
                subtotal = qtyShirts * pricePerShirt;
                tax = subtotal * .08;
                total = subtotal + tax;
            }

            lblSubtotal.Text = subtotal.ToString("C");
            lblTax.Text = tax.ToString("C");
            lblTotal.Text = total.ToString("C");
        }
    }
}
