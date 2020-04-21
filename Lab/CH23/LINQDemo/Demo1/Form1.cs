using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class FRMSales : Form
    {
        //winner winner chicken dinner
        SalesDataContext salesDb = new SalesDataContext();

        public FRMSales()
        {
            InitializeComponent();

            //Read LINQ
            var data = salesDb.Customers
               // .Where(c => c.Budget == 1000)
                .Select(c => c);

            List<Customer> customers = data.ToList();

            foreach (Customer c in customers)
            {
                lblResult.Text += $"{c.FirstName} {c.LastName} has a budget of {c.Budget}\n";
            }

           

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Create w LINQ
            Customer customerInsert = new Customer()
            {
                FirstName = "Betsy",
                LastName = "Smith",
                Budget = 4000
            };

            salesDb.Customers.InsertOnSubmit(customerInsert);

            salesDb.SubmitChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update Betsy
            var data = salesDb.Customers
               .Where(c => c.FirstName == "Betsy")
               .Select(c => c);

           // Customer cust = (Customer)data;

            List<Customer> customers = data.ToList();

            customers[0].FirstName = "Elizabeth";
            salesDb.SubmitChanges();
            lblResult.Text = "Updated";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var data = salesDb.Customers
              .Where(c => c.CustomerId == 5)
              .Select(c => c);

            List<Customer> customers = data.ToList();

            salesDb.Customers.DeleteOnSubmit(customers[0]);

            salesDb.SubmitChanges();

            lblResult.Text = "Customer Deleted";
        }
    }
}
