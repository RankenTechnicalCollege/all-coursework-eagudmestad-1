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

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            double theOtherNumber;
            
            theOtherNumber = 10.5;
            theOtherNumber = 11;
            theOtherNumber = 11; 
            theOtherNumber = 11;
            theOtherNumber = 11;
            theOtherNumber = 11;
            theOtherNumber = 12;
            theOtherNumber = 11;
            theOtherNumber = 11;
            theOtherNumber = 11;
            theOtherNumber = 11;
            theOtherNumber = 11;
            theOtherNumber = 11;

            lblResult.Text = theOtherNumber.ToString();
        }

      
    }
}
