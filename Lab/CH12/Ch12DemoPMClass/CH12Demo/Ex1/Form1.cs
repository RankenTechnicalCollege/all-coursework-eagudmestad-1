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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Create an instance of the Student class
          //  Student aSleepyStudent = new Student();
            Student aWokeStudent = new Student();
            Student someOtherStudent = new Student("LeAndre", 20);
            //Call the mutator to set the instance field
          //  aSleepyStudent.SetName(txtName.Text);
           // aSleepyStudent.SetAge(Convert.ToInt32(txtAge.Text));

            aWokeStudent.SetName("Gudmestad");
            aWokeStudent.SetAge(32);

            someOtherStudent.SetAge(21);

            //Call the accessor to retrieve the instance field
           // lblResult.Text = $"WAKE UP {aSleepyStudent.GetName().ToUpper()} Act Your AGE! ({aSleepyStudent.GetAge()})";
            lblResult.Text += $"{aWokeStudent.GetName()} is a good example at the age of {aWokeStudent.GetAge()}";

        }
    }
}
