using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            try
            {
                Order myorder = new Order(short.Parse(txtItemNum.Text), byte.Parse(txtQuantity.Text), byte.Parse(txtEstDelivery.Text));
                lblResult.Text = "Order Valid";
            }
            catch(InvalidItemNumberException ex)
            {
                lblResult.Text = ex.Message;
            }
            catch(InvalidQuantityException ex)
            {
                lblResult.Text = ex.Message;
            }
            catch(InvalidDeliveryDaysException ex)
            {
                lblResult.Text = ex.Message;
            }

        }
    }
}
