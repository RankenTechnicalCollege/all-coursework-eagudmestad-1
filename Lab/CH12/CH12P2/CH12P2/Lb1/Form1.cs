using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool hasSundae = chkSundae.Checked;
            bool hasSoda = chkSoda.Checked;

            string orderName = txtName.Text;
            if(string.IsNullOrEmpty(orderName))
            {
                lblErrorName.Text = "Name Required";
            }
            else if(hasSundae == false && hasSoda == false)
            {
                lblErrorName.Text += " No Food Selected";
            }
            else
            {
                //No Errors
                Order myOrder = new Order(orderName, hasSundae, hasSoda);

                //Sundae Toppings
                bool hasSprinkles = chkSprinkles.Checked;
                bool hasNuts = chkNuts.Checked;
                bool hasSyrup = chkCS.Checked;

                //Soda Flavors
                
                bool hasLime = chkLime.Checked;
                bool hasPeach = chkPeach.Checked;
                bool hasMango = chkMango.Checked;

                if(hasSprinkles && hasNuts && hasSyrup)
                {
                    lblErrorToppings.Text = "Only 2 toppings allowed";
                }
                
                if(hasSprinkles)
                {
                    myOrder.Sundae.AddTopping(SundaeTopping.SPRINKLES);
                }

                if(hasNuts)
                {
                    myOrder.Sundae.AddTopping(SundaeTopping.NUTS);
                }

                if(hasSyrup)
                {
                    myOrder.Sundae.AddTopping(SundaeTopping.CHOCOLATE_SYRUP);
                }



            }

        }
    }
}
