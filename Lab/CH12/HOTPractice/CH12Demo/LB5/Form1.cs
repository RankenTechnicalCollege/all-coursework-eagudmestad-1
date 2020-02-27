using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB5
{
    public partial class Form1 : Form
    {
        List<Job> myJobs = new List<Job>();
        public Form1()
        {
            InitializeComponent();
            myJobs.Add(new Job("Wash Car", 2, 10));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string userJobInput = txtDescription.Text.ToLower();
            bool jobFound = false;
            int foundPosition = -1;


            //Loop through current jobs
            for (int i = 0; i < myJobs.Count; i++)
            {
                if(myJobs[i].Description.ToLower() == userJobInput)
                {
                    jobFound = true;
                    //Update job
                    myJobs[i].HourlyFee = Convert.ToSingle(txtHourlyFee.Text);
                    myJobs[i].HoursToComplete = Convert.ToSingle(txtHoursToComplete.Text);
                    foundPosition = i;
                }
            }

            if(jobFound == false)
            {
                myJobs.Add(new Job(txtDescription.Text, Convert.ToSingle(txtHoursToComplete.Text), Convert.ToSingle(txtHourlyFee.Text)));
                foundPosition = myJobs.Count - 1;
            }


            lblResult.Text = $"Description: {myJobs[foundPosition].Description}\n " +
                $"Hourly Rate: {myJobs[foundPosition].HourlyFee.ToString("C")}\n" +
                $"Number of Hours to Complete: {myJobs[foundPosition].HoursToComplete}\n" +
                $"Total Fee {myJobs[foundPosition].TotalFee.ToString("C")}\n";
        }
    }
}
