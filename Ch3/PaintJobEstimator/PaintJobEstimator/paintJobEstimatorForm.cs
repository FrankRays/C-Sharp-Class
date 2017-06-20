using System;
using System.Windows.Forms;

namespace PaintJobEstimator
{
    /// <summary>
    ///Program: PaintJobEstimator
    ///Devloper: Sebastian Hoer
    ///Date: 2/03/2017
    ///Description: An application that estimstates bids for paint jobs.
    /// </summary>
    
   
    public partial class paintJobEstimatorForm : Form
    {

        //Constant variables for calculations 
        private const int feetToGallons = 115;
        private const int laborHoursToGallons = 8;
        private const int dollersToHours = 20;

        public paintJobEstimatorForm()
        {
            InitializeComponent();
        }// end paintJobEstimatorForm constructor 

        private void estimateJob() {

            // Calculates the the bid for the paint job

            //Variables to hold user input from Text boxs
            double priceOfPaint = 0.0, squareFeet = 0.0;

            //Variables to store calculated values before displaying
            int gallonsRequired = 0;
            int hoursOfLabor = 0;
            double costOfPaint = 0.0;
            double costOfLabor = 0.0;
            double Total = 0.0;


            /*Valadaion code for user input, if a user input can not be parsed to double then
             Display errorBox, clear the inputs, clear output labels and return the method.
             */
            if (!Double.TryParse
                (tbSquareFeet.Text.ToString(),
                out squareFeet)) { errorBox(); clearControls();  return; }

            if (!Double.TryParse
                (tbPricePerGallon.Text.ToString(),
                out priceOfPaint)) { errorBox(); clearControls(); return; }


            //Code that calculates the bid.
            gallonsRequired = (int)Math.Ceiling(squareFeet / feetToGallons);

            hoursOfLabor = gallonsRequired * laborHoursToGallons;

            costOfPaint = gallonsRequired * priceOfPaint;

            costOfLabor = hoursOfLabor * dollersToHours;

            Total = costOfLabor + costOfPaint;


            //Displays and formats the bid Data
            lbGallonsOfPaintOutput.Text = gallonsRequired.ToString();

            lbLaborHoursOutput.Text = hoursOfLabor.ToString();

            lbCostOfPaintOutput.Text = costOfPaint.ToString("c");

            lbCostOfLaborOutput.Text = costOfLabor.ToString("c");

            lbTotalCostOutput.Text = Total.ToString("c");


        }// end estimateJob method



        private static void errorBox()
        {
            // displays messagebox with the message Invalid input. 
            MessageBox.Show("Invalid input.");
        }// end erroBox method

        private void clearControls() {

            // clears the input Textboxs and Output labels
            tbPricePerGallon.Text = "";

            tbSquareFeet.Text = "";

            lbGallonsOfPaintOutput.Text = "";

            lbLaborHoursOutput.Text = "";

            lbCostOfPaintOutput.Text = "";

            lbCostOfLaborOutput.Text = "";

            lbTotalCostOutput.Text = "";

        }// end clearControls

        private void btnClear_Click(object sender, EventArgs e)
        {
            //button that clears the controls
            clearControls();
        }// end btnClear_Click

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //button that Estimates the bid
            estimateJob();
        }// end btnEnter_Click
    }
}
