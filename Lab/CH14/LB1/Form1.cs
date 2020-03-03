using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class Form1 : Form
    {
        List<Letter> letters = new List<Letter>(20);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string trackingNum = txtTrackingNumber.Text;

            if(String.IsNullOrEmpty(trackingNum))
            {
                //Letter
                letters.Add(new Letter(txtRecipient.Text, DateTime.Parse(txtSentDate.Text)));
            }
            else
            {
                //Certified Letter
                letters.Add(new CertifiedLetter(txtRecipient.Text, DateTime.Parse(txtSentDate.Text), txtTrackingNumber.Text));
            }
            //Read the current label into a variable
            string currentLabel = lblOutput.Text;

            //Output the last letter followed by the variable
            lblOutput.Text = letters[letters.Count - 1].ToString() + "\n" + currentLabel;
        }
    }
}
