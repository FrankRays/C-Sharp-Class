using System;
using System.Windows.Forms;

namespace FatPercentageCalculator
{
    /// <summary>
    ///Program: fatPercentageCalulator
    ///Devloper: Sebastian Hoer
    ///Date: 2/10/2017
    ///Description: an app that finds the Calories from fat and its percentage from fat.
    /// </summary>


    public partial class fatPercentageCalculatorForm : Form
    {



        public fatPercentageCalculatorForm()
        {
            InitializeComponent();
        }// end fatPercentageCalculatorForm constructor 

        private void btnClear_Click(object sender, EventArgs e)
        {
            //button that clears the controls
            tbFatGrams.Text = "";

            tbCalories.Text = "";

            lbCaloriesFat.Text = "";

            lbPercentCalories.Text = "";

            lbLowFatOutput.Text = "";

        }// end btnClear_Click

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // method variables

            double caloriesInput = 0.0;
            double fatGramsInput = 0.0;

            double caloriesFromFat = 0.0;
            double percentCaloriesFromFat = 0.0;

            //reset Low fat and Output lables
            lbLowFatOutput.Text = "";

            lbCaloriesFat.Text = "";

            lbPercentCalories.Text = "";

            //Valdaton logic both inputs must be valid numbers and must be grater than zero
            bool caloriesIsValid = Double.TryParse(tbCalories.Text.ToString(), out caloriesInput)
                && caloriesInput > 0;

            bool fatGramsIsValid = Double.TryParse(tbFatGrams.Text.ToString(), out fatGramsInput)
                && fatGramsInput > 0;

            bool inputsValid = caloriesIsValid && fatGramsIsValid;

            //display error messages if valdaton logic false
            lbErrorCalories.Visible = !caloriesIsValid;

            lbErrorFatGrams.Visible = !fatGramsIsValid;

            //if valdaton logic is true calculate calories from fat
            if (inputsValid)
            {

                caloriesFromFat = fatGramsInput * 9;

                //if Calories from fat is grater than total calories show error message and return method  
                if (caloriesFromFat > caloriesInput)
                {
                    MessageBox.Show("The Calories or Fat grams is incorrect.");
                    lbErrorCalories.Visible = true;
                    lbErrorFatGrams.Visible = true;

                    return;
                }// end if(caloriesFromFat > caloriesInput) true

                
                percentCaloriesFromFat = caloriesFromFat / caloriesInput;

                //display calculated data
                lbCaloriesFat.Text = caloriesFromFat.ToString();

                lbPercentCalories.Text = percentCaloriesFromFat.ToString("P");

                //display is low fat if check box is checked
                if (cbLowFat.Checked)
                {

                    if (percentCaloriesFromFat < .30)
                    {

                        lbLowFatOutput.Text = "A low fat food!";

                    }//end  if (percentCaloriesFromFat < .30) true
                    else
                    {

                        lbLowFatOutput.Text = "Not a low fat food!";

                    }// end else (percentCaloriesFromFat < .30) false

                }// end if (cbLowFat.Checked) true

            }//end if(inputsValid) true
            
        }// end btnEnter_Click

    }// end fatPercentageCalculatorForm

}// end Namespace