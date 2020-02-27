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
        double allOrdersTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblErrorMixins.Text = "";
            lblErrorName.Text = "";
            lblErrorToppings.Text = "";
            
            bool hasSprinkles=false, hasNuts=false, hasSyrup=false, hasLime=false, hasPeach=false, hasMango=false;
            int numSundaeTopings = 0,numSodaFlavors=0;

            if(chkSprinkles.Checked){hasSprinkles = true;numSundaeTopings++;}
            if(chkNuts.Checked){hasNuts = true;numSundaeTopings++;}
            if(chkCS.Checked){hasSyrup = true;numSundaeTopings++;}

            if (chkLime.Checked){ hasLime = true;numSodaFlavors++;}
            if (chkPeach.Checked) { hasPeach = true;numSodaFlavors++;}
            if (chkMango.Checked) { hasMango = true;numSodaFlavors++;}

            bool validOrder = true;

            //Data Validation
            string orderName = txtName.Text;
            if(String.IsNullOrEmpty(orderName))
            {
                lblErrorName.Text = "Name Required";
                validOrder = false;
            }
            if(chkSundae.Checked==false && chkSoda.Checked==false)
            {
                lblErrorName.Text += " No Food selected";
                validOrder = false;
            }
            if(numSundaeTopings>2)
            {
                lblErrorToppings.Text = "Only 2 toppings allowed";
                validOrder = false;
            }
            if(numSodaFlavors>1)
            {
                lblErrorMixins.Text = "Only 1 mixing allowed";
                validOrder = false;
            }

            if(validOrder)
            {
                Order anOrder = new Order(txtName.Text, chkSundae.Checked, chkSoda.Checked);

                //Data output
                //Output Name
                lblOutput.Text += anOrder.Name + "\n-----------------\n";
                
                //Adding Topings and Output for Sundae
                if(anOrder.Sundae != null)
                {
                    //Add Toppings for Sundae
                    if (hasSprinkles) {anOrder.Sundae.AddTopping(SundaeTopping.SPRINKLES); }
                    if (hasNuts) {anOrder.Sundae.AddTopping(SundaeTopping.NUTS); }
                    if (hasSyrup) {anOrder.Sundae.AddTopping(SundaeTopping.CHOCOLATE_SYRUP); }

                    //Output for Sundae
                    lblOutput.Text += "Sundae - ";
                    
                    if(anOrder.Sundae.ToppingCount == 0)
                    {
                        lblOutput.Text += anOrder.Sundae.GetTopping(0) + " ";
                    }
                    
                    for (int i = 0; i < anOrder.Sundae.ToppingCount; i++)
                    {
                        lblOutput.Text += anOrder.Sundae.GetTopping(i) + " ";
                    }
                    lblOutput.Text += $"- {anOrder.Sundae.Price}\n";
                }

                if(anOrder.Soda != null)
                {
                    //Add Toppings for Soda
                    if (hasMango) { anOrder.Soda.AddFlavor(SodaFlavor.MANGO);}
                    if (hasPeach) { anOrder.Soda.AddFlavor(SodaFlavor.PEACH); }
                    if (hasLime) { anOrder.Soda.AddFlavor(SodaFlavor.LIME); }

                    //Output for Soda
                    lblOutput.Text += $"Soda - {anOrder.Soda.Flavor} - {anOrder.Soda.Price}\n";
                }

                lblOutput.Text += "\n";

                allOrdersTotal += anOrder.Price;
                lblTotal.Text = $"Total: {allOrdersTotal.ToString("C")}";

            }
            
        }
    }
}
