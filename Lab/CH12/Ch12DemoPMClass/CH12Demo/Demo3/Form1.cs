using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creates an instance (object) of the Account Class
            Account myAccount = new Account();
            myAccount.UserName = "Gudmestad";
            myAccount.AccountNumber = "1111";
            myAccount.AccountPin = "2222";

            Account yourAccount = new Account() {UserName="Glover",AccountNumber="0000",AccountPin="1234"};

            Account thirdAccount = new Account();
            Account fourthAccount = new Account();

            lblOutput.Text = $"My account info:\n" +
                $"User Name: {myAccount.UserName}\n" +
                $"Account Number: {myAccount.AccountNumber}\n" +
               $"Account Pin: {myAccount.AccountPin}\n" + 
               $"Total # of Accounts: {Account.GetTotalAccounts()}";
        }
    }
}
