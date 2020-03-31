using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class frmBmi : Form
    {
        public frmBmi()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            try
            {

                float weight, height;

                if (!float.TryParse(txtWeight.Text, out weight)) 
                {
                    throw new InvalidWeightException();
                }
                if (!float.TryParse(txtHeight.Text, out height))
                {
                    throw new InvalidHeightException();
                }

                Bmi userBmi = frmBmi.CalcBmi(weight, height);
                lblResult.Text = $"BMI: {userBmi.BMI:F1}\nCategory: {userBmi.WeightCategory}";
                lblResult.ForeColor = Color.Black;
            }
            catch (InvalidWeightException ex)
            {
                lblResult.Text = ex.Message;
            }
            catch(InvalidHeightException ex)
            {
                lblResult.Text = ex.Message;
            }
        }

        public static Bmi CalcBmi(float weightInPounds,float heightInInches)
        {
            if(weightInPounds < 70 || weightInPounds > 300)
            {
                throw new InvalidWeightException();
            }

            if(heightInInches < 60 || heightInInches > 84)
            {
                throw new InvalidHeightException();
            }

            //Do calc
            float bmi =  (703 * weightInPounds) / (heightInInches * heightInInches);
            //return bmi w weight category
            WeightCategory userWeightCategory;
            if(bmi >= 30)
            {
                //obese
                userWeightCategory = WeightCategory.OBESE;
            }
            else if(bmi >=25)
            {
                //overweight
                userWeightCategory = WeightCategory.OVERWEIGHT;
            }
            else if(bmi >= 18.5)
            {
                //healthy
                userWeightCategory = WeightCategory.NORMAL;
            }
            else
            {
                userWeightCategory = WeightCategory.UNDERWEIGHT;
            }

            return new Bmi(weightInPounds, heightInInches, bmi, userWeightCategory);

        }
    }
}
