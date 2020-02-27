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
        //Instance Field
        private List<FlashCard> myCards = new List<FlashCard>(20);
        
        //Method w the same name as the class is called a CONSTRUCTOR
        public Form1()
        {
            myCards.Add(new FlashCard("SQL", "Structured Query Language"));
            myCards.Add(new FlashCard("HTML", "HyperText Markup Language"));
            myCards.Add(new FlashCard("CSS", "Cascading StyleSheet"));
            myCards.Add(new FlashCard("JS", "JavaScript"));

            FlashCard aCard = new FlashCard("C#", "Microsoft's C Sharp");
            myCards.Add(aCard);


            InitializeComponent();
        }

        private void btnDefine_Click(object sender, EventArgs e)
        {
            //Hide controls
            btnAdd.Visible = false;
            txtDefinition.Visible = false;
            string inputTerm = txtTerm.Text.ToLower();

            bool found = false;

            for (int i = 0; i < myCards.Count; i++)
            {
                if(myCards[i].GetTerm().ToLower() == inputTerm)
                {
                    lblDefinition.Text = myCards[i].GetDefinition();
                    found = true;
                }
            }

            if(found == false)
            {
                lblDefinition.Text = "I don't know that term yet.  What does it mean?";
                btnAdd.Visible = true;
                txtDefinition.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myCards.Add(new FlashCard(txtTerm.Text, txtDefinition.Text));
            MessageBox.Show("New Flash Card Added!");
            txtDefinition.Text = "";
            lblDefinition.Text = "";
            txtDefinition.Visible = false;
            btnAdd.Visible = false;
        }
    }
}
