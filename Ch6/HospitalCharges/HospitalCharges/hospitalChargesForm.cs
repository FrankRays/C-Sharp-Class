using System;
using System.IO;
using System.Windows.Forms;


/// <summary>
/// Program: Hospital Charges Form
/// Devloper: Sebastian Hoer
/// Date:3/2/2017
/// Purpose: This Program calculates the cost of a Hospital Stay
/// </summary>
namespace HospitalCharges
{
    public partial class hospitalChargesForm : Form
    {
        
        public hospitalChargesForm()
        {
            InitializeComponent();
            saveAsToolStripMenuItem.Enabled = false;
        }// end hospitalChargesForm constructor

        #region validation code
        private int validateInt(TextBox Tb,Label Error) {
            // this method validates a text box input to an int if valid and displays an error if not.
           int validateNumber = 0;

            Error.Visible = !(Int32.TryParse(Tb.Text.ToString(), out validateNumber)
                && validateNumber >= 0);
             
            return validateNumber;
        }//end validateInt Method

        private double validateDouble(TextBox Tb,Label Error)
        {
            // this method validates a text box input to an double if valid and displays an error if not.
            double validateNumber = 0;

            Error.Visible = !(Double.TryParse(Tb.Text.ToString(), out validateNumber)
                 && validateNumber >= 0);

            return validateNumber;
        }// end validateDouble method

        private bool validateInputs() {
            //this method checks if all inputs are valid and returns false if any input is invaild and displays a error.
            bool[] Errors = new bool[] {
            lblErrorDays.Visible,
            lblErrorMedication.Visible,
            lblErrorSurgical.Visible,
            lblErrorLab.Visible,
            lblErrorPhysical.Visible
        };
            foreach (bool valid in Errors) {

                if (valid) { lblError.Visible = true; return false; }
                lblError.Visible = false;
            }//end foreach (bool valid in Errors)

            return true;

        }//end validateInputs method

        #endregion validation code

        #region calculation code and methods
        private double CalcStayCharges(int Days) { return Days * 350; }//end CalcStayCharges method

        private double CalcMiscCharges(double MedicationCharge, double SurgicalCharge, double LabCharge, double PhysicalRehab) {
           return MedicationCharge + SurgicalCharge + LabCharge + PhysicalRehab;
        }//end CalcMiscCharges method

        private double CalcTotalCharges(double StayCharges,double MiscCharges) {
            return StayCharges + MiscCharges;
        }//end CalcTotalCharges method
        #endregion calculation code and methods

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            //when the user changes the text in the input the program runs the cal.
            // local var and validation 
            int Days = validateInt(tbDays, lblErrorDays);
            double MedicationCharge = validateDouble(tbMedication, lblErrorMedication);
            double SurgicalCharge = validateDouble(tbSurgical, lblErrorSurgical);
            double LabCharge = validateDouble(tbLab, lblErrorLab);
            double PhysicalRehab = validateDouble(tbPhysical, lblErrorPhysical);

            // if all inputs are valid run calc methods and return textBox_TextChanged method
            if (validateInputs()) {

                double StayCharges = CalcStayCharges(Days);
                double MiscCharges = CalcMiscCharges(MedicationCharge, SurgicalCharge, LabCharge, PhysicalRehab);
                DateTime dt = DateTime.Now;
                //display Calculated data
                tbStayCharge.Text = StayCharges.ToString("c");
                tbMiscCharge.Text = MiscCharges.ToString("c");
                tbTotal.Text = CalcTotalCharges(StayCharges, MiscCharges).ToString("c");
                tbDate.Text = dt.ToString("MMMM dd, yyyy");
                tbTime.Text = dt.ToString("H:mm");
                saveAsToolStripMenuItem.Enabled = true;
                return;
            }//end if (validateInputs())
            // if validateInputs returns a false clear the Totals.
            saveAsToolStripMenuItem.Enabled = false;

            tbStayCharge.Text = "";
            tbMiscCharge.Text = "";
            tbTotal.Text = "";
            tbDate.Text = "";
            tbTime.Text = "";
        }//end textBox_TextChanged method

        #region File Method code
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //on click prepares data to be saved and calls the writeAppendChargeToFile method to save data.
            string StayCharge = tbStayCharge.Text.ToString();
            string MiscCharge = tbMiscCharge.Text.ToString();
            string Total = tbTotal.Text.ToString();
            string Date = tbDate.Text.ToString();
            string Time = tbTime.Text.ToString();

            string chargeData = "Stay: " + StayCharge + " ,Misc: " + MiscCharge + " ,Total: " + Total + " ,DateTime: " + Date + ", " + Time;

            writeAppendChargeToFile(chargeData);

        }//end saveAsToolStripMenuItem_Click method

        private void writeAppendChargeToFile(string chargeData) {
            //Saves calculated data to file
            try
            {

                if (saveFileDialog.ShowDialog() == DialogResult.OK) {

                    using (StreamWriter outputFile = File.AppendText(saveFileDialog.FileName)) {

                        outputFile.WriteLine(chargeData);
                    }//end using
                }//end if

            }//end try
            catch (Exception ex) {

                MessageBox.Show(ex.ToString());
            }//end catch

        }//end writeAppendChargeToFile method
        #endregion File Method code

        #region select all functions 
        private void tbDays_Enter(object sender, EventArgs e)
        {
            tbDays.SelectAll();
        }// end tbDays_Enter

        private void tbMedication_Enter(object sender, EventArgs e)
        {
            tbMedication.SelectAll();
        }// end tbMedication_Enter

        private void tbSurgical_Enter(object sender, EventArgs e)
        {
            tbSurgical.SelectAll();
        }// end tbSurgical_Enter

        private void tbLab_Enter(object sender, EventArgs e)
        {
            tbLab.SelectAll();
        }// end tbLab_Enter

        private void tbPhysical_Enter(object sender, EventArgs e)
        {
            tbPhysical.SelectAll();
        }// end tbPhysical_Enter
        #endregion select all functions 

    }// end hospitalChargesForm
}// end HospitalCharges namespace
