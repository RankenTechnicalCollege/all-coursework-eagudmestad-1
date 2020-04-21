using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {

        DataClasses1DataContext db = new DataClasses1DataContext();
       
        public Form1()
        {
            InitializeComponent();
           // Student s1 = new Student() { FirstName = "Bob", LastName = "Gudmestad" };
           // db.Students.InsertOnSubmit(s1);
            
            //db.Students.DeleteOnSubmit(s1);
            db.SubmitChanges();
          
            //s1.LastName = "Jenkens";
            
            //db.SubmitChanges();

            //var data = from s in db.Students
             //          select s;

            var data2 = db.Students
                //.Where(s => s.GetType().Eq)
                .OrderBy(s=>s.FirstName)
                .Select(s => s);
                

            List<Student> students = data2.ToList();
            lblResult.Text = "";
            foreach (var item in students)
            {
                lblResult.Text += item.FirstName + " " + item.LastName + "\n";
            }
        }
    }
}
