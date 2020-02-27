using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShirtSizes
{
    public partial class frmCoolShirts : Form
    {
        public frmCoolShirts()
        {
            InitializeComponent();

        }
        int qtySmall = 0, qtyMedium = 0, qtyLarge = 0;



        private void frmCoolShirts_Load(object sender, EventArgs e)
        {

        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            AddShirt("S");
            ShowInvoice();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            AddShirt("M");
            ShowInvoice();
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            AddShirt("L");
            ShowInvoice();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOrder();
        }

        private void ClearOrder()
        {
            qtyLarge = 0;
            qtyMedium = 0;
            qtySmall = 0;
            lblLarge.Text = "";
            lblMedium.Text = "";
            lblSmall.Text = "";
            lblQtyLarge.Text = "";
            lblQtyMedium.Text = "";
            lblQtySmall.Text = "";
            lblSubtotal.Text = "";
            lblTotal.Text = "";
            lblTax.Text = "";
        }

        private void AddShirt(string shirtSize)
        {
            //Accepts a shrit size as a string and adds it to the users order
           switch(shirtSize)
            {
                case "S":
                    qtySmall++;
                    lblSmall.Text = qtySmall.ToString();
                    lblQtySmall.Text = qtySmall.ToString();
                    break;
                case "M":
                    qtyMedium++;
                    lblMedium.Text = qtyMedium.ToString();
                    lblQtyMedium.Text = qtyMedium.ToString();
                    break;
                case "L":
                    qtyLarge++;
                    lblLarge.Text = qtyLarge.ToString();
                    lblQtyLarge.Text = qtyLarge.ToString();
                    break;
            }
        }

        private void ShowInvoice()
        {
            //Displays the invoice to the user
            decimal subtotal = ((qtySmall * 9.99m) + (qtyMedium * 10.99m) + (qtyLarge * 11.99m));
            decimal tax = subtotal * .07m;
            decimal total = subtotal + tax;

            lblSubtotal.Text = subtotal.ToString("C");
            lblTax.Text = tax.ToString("C");
            lblTotal.Text = total.ToString("C");
        }


    }
}
