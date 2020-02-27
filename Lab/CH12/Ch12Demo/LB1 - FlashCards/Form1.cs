using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1___FlashCards
{
    public partial class Form1 : Form
    {
        List<FlashCard> myCards = new List<FlashCard>();
        
        public Form1()
        {
            InitializeComponent();
            myCards.Add(new FlashCard("SQL", "Structured Query Language"));
            myCards.Add(new FlashCard("HTML", "HyperText Markup Language"));
            myCards.Add(new FlashCard("CSS", "Cascading Style Sheet"));
            myCards.Add(new FlashCard("JS", "JavaScript"));
            myCards.Add(new FlashCard("C#", "C Sharp"));
        }

        private void btnDefine_Click(object sender, EventArgs e)
        {
            //Hide controls every button click
            btnAdd.Visible = false;
            txtDefinition.Visible = false;

            string searchTerm = txtTerm.Text;
            bool found = false;
            
            for (int i = 0; i < myCards.Count; i++)
            {
                if(searchTerm.ToLower().Equals(myCards[i].GetTerm().ToLower()))
                {
                    found = true;
                    lblDefinition.Text = myCards[i].GetDefinition();
                }
            }

            if(found == false && searchTerm != "")
            {
                lblDefinition.Text = "I don't know that term.  What does it mean?";
                btnAdd.Visible = true;
                txtDefinition.Visible = true;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(myCards.Count != 20)
            { 
                myCards.Add(new FlashCard(txtTerm.Text, txtDefinition.Text));
                MessageBox.Show("New Term Added");
                btnAdd.Visible = false;
                txtDefinition.Visible = false;
                lblDefinition.Text = "";
            }
            else
            {
                MessageBox.Show("No More Terms Allowed!");
            }

        }
    }
}
