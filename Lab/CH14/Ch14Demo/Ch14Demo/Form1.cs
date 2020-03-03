using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch14Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreator_Click(object sender, EventArgs e)
        {
            Animal someMysterioiusAnimal = new Animal();
            someMysterioiusAnimal.Name = "Sam";
            someMysterioiusAnimal.Weight = 5;
            
            Animal anotherAnimal = new Animal();
            anotherAnimal.Name = "Sam";
            anotherAnimal.Weight = 5;

            if(someMysterioiusAnimal.Equals(anotherAnimal))
            {
                //They're equal
            }
            else
            {
                //not equal
            }


            Dog chewie = new Dog() { Name = "Chewie", Weight = 50, SenseOfSmell = 8 };
           

            Cat sam = new Cat() { Name = "Sam",Weight=16};

           // Move(sam);

            //Upcasting --- GOOD
            Animal a1 = new Dog();

            Type t = a1.GetType();

            lblOutput.Text = $"Namespace Property: {t.BaseType.Name}";

            
            Animal a2 = new Cat();

            //DowCasting -- (not a thing)
           

        }
        //Method that displays Polymorphic Behavior
        public void Move(Animal ani)
        {
           lblOutput.Text = ani.Walk();
        }
    }
}
