using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int idCount = 0;
        int count = 0;
        Student[] students = new Student[20];
        private void button1_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            idCount++;
            //Student s1 = new Student();
            //s1.SetId(22684);
            //s1.SetStudentName("Billy");

            //Student s2 = new Student();
            //s2.SetId(22685);
            //s2.SetStudentName("Jane");

            //Student s3 = new Student("Chris", 22686);

            //lblOutput.Text = $"{s1.ToString()}\n";
            //lblOutput.Text += $"{s2.ToString()}\n";
            //lblOutput.Text += $"{s3.ToString()}\n";

            students[count] = new Student(txtStudentName.Text, idCount);
            count++;
            DisplayStudents();
        }
        
        private void DisplayStudents()
        {
            for (int i = 0; i < count; i++)
            {
                lblOutput.Text += students[i].ToString();
            }
        }
    }
}

