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
    public partial class frmInventory : Form
    {
        List<Item> items = new List<Item>();
        int foundPosition = -1;
        public frmInventory()
        {
            InitializeComponent();
            items.Add(new Item()
            {
                Name = "TNT",
                UPC = "1000-1000",
                StorePrice = 100,
                CasePrice = 90,
                UnitsPerCase=1,
                Distributor="Acme"
            });

            items.Add(new Item()
            {
                Name = "Tar",
                UPC = "2000-2000",
                StorePrice = 1000,
                CasePrice = 50,
                UnitsPerCase = 2,
                Distributor = "Acme"
            });
        }

        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            //Set the panels to invisible
            pnlChangePrice.Visible = false;
            pnlDeleteItem.Visible = false;

            string searchName = txtSearchItemName.Text.ToLower();

            bool itemFound = false;

            for (int i = 0; i < items.Count; i++)
            {
                if(items[i].Name.ToLower() == searchName)
                {
                    lblName.Text = items[i].Name;
                    lblUPC.Text = items[i].UPC;
                    lblPrice.Text = items[i].StorePrice.ToString("C");
                    lblCaseCost.Text = items[i].CasePrice.ToString("C");
                    lblCaseUnits.Text = items[i].UnitsPerCase.ToString();
                    lblDistributor.Text = items[i].Distributor;
                    itemFound = true;
                    foundPosition = i;
                    pnlChangePrice.Visible = true;
                    pnlDeleteItem.Visible = true;
                }
            }

            if(itemFound == false)
            {
                lblName.Text = "";
                lblUPC.Text = "";
                lblPrice.Text = "";
                lblCaseCost.Text = "";
                lblCaseUnits.Text = "";
                lblDistributor.Text = "";
                foundPosition = -1;
            }
        }


        private void btnUPCSearch_Click(object sender, EventArgs e)
        {
            //Set the panels to invisible
            pnlChangePrice.Visible = false;
            pnlDeleteItem.Visible = false;

            string searchUPC = txtSearchUPC.Text;

            bool itemFound = false;

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].UPC.ToLower() == searchUPC)
                {
                    lblName.Text = items[i].Name;
                    lblUPC.Text = items[i].UPC;
                    lblPrice.Text = items[i].StorePrice.ToString("C");
                    lblCaseCost.Text = items[i].CasePrice.ToString("C");
                    lblCaseUnits.Text = items[i].UnitsPerCase.ToString();
                    lblDistributor.Text = items[i].Distributor;
                    itemFound = true;
                    foundPosition = i;
                    pnlChangePrice.Visible = true;
                    pnlDeleteItem.Visible = true;
                }
            }

            if (itemFound == false)
            {
                lblName.Text = "";
                lblUPC.Text = "";
                lblPrice.Text = "";
                lblCaseCost.Text = "";
                lblCaseUnits.Text = "";
                lblDistributor.Text = "";
                foundPosition = -1;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            lblAddItemError.Text = "";
            //string[] UPCs = new string[items.Count];

            string upc = txtUPC.Text.ToLower();

            bool duplicates = false;

            for (int i = 0; i < items.Count; i++)
            {
                if(upc == items[i].UPC)
                {
                    //Duplicate UPCs Found
                    duplicates = true;
                    lblAddItemError.Text += "That is a duplicate UPC.  Please use a different value.";
                }
            }

            if(txtAccessKey.Text == "password")
            {
                if(duplicates == false)
                { 
                    string itemName = txtItemName.Text;
                   // string UPC = txtUPC.Text;
                    decimal storePrice = Convert.ToDecimal(txtStorePrice.Text);
                    decimal casePrice = Convert.ToDecimal(txtCostPerCase.Text);
                    int unitsPerCase = Convert.ToInt32(txtUnitsPerCase.Text);
                    string distributor = txtDistributor.Text;

                    items.Add(new Item()
                    {
                        Name = itemName,
                        UPC = upc,
                        StorePrice = storePrice,
                        CasePrice = casePrice,
                        UnitsPerCase = unitsPerCase,
                        Distributor = distributor
                    });
                    MessageBox.Show("Item added!");
                }
            }
            else
            {
                lblAddItemError.Text += "Access Key Incorrect.";
            }



        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            lblUpdatePriceError.Text = "";
            if(txtUpdatePriceAccessKey.Text.Equals("password"))
            {
                items[foundPosition].StorePrice = Convert.ToDecimal(txtUpdatePrice.Text);
                lblPrice.Text = items[foundPosition].StorePrice.ToString("C");
                MessageBox.Show("Price Updated!");
            }
            else
            {
                lblUpdatePriceError.Text += "Access Key Incorrect";
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            lblDeleteItemError.Text = "";
            string verifyUPC = txtVerifyUPC.Text;

            if(txtDeleteItemAccessKey.Text.Equals("password"))
            {
                if(verifyUPC.Equals(items[foundPosition].UPC))
                {
                    items.Remove(items[foundPosition]);
                    MessageBox.Show("Item Deleted!");
                    lblName.Text = "";
                    lblUPC.Text = "";
                    lblPrice.Text = "";
                    lblCaseCost.Text = "";
                    lblCaseUnits.Text = "";
                    lblDistributor.Text = "";
                    foundPosition = -1;
                }
                else
                {
                    lblDeleteItemError.Text += "Invalid UPC";
                }
            }
            else
            {
                lblDeleteItemError.Text += "Access Key Incorrect";
            }
        }
    }
}
