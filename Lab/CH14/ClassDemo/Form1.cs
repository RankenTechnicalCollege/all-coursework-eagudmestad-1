using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student() { Name = "Bill", Age = 45 };

            //Shallow Copy
            //Student student2 = aStudent;

            //student2.Name = "Tom";

            Student student2 = (Student)aStudent.Clone();
            student2.Name = "Tom";

            DoSomething(student2); 
        }

        public void DoSomething(Person p1)
        {
            lblOutput.Text = p1.Name;
        }
    }
}
