using System;
using System.Windows.Forms;
/// <summary>
/// Devloper: Sebastian Hoer
/// Date: 4/7/2017
/// </summary>
namespace ProductionWorkerClassApp
{
    public partial class productionWorkerClassApp : Form
    {
        //globals
        private string employeeName;
        private int employeeNumber;
        private int shift;
        private double payRate;
        
        public productionWorkerClassApp()
        {
            InitializeComponent();

            //start with the Create button disabled
            btCreate.Enabled = false;
        }//end productionWorkerClassApp constructor  

        #region validate
        public void validateInput(){

            //This Method Validates the inputs and enables or disables the create button
            shift = (int)nudShift.Value;

            lblNameError.Visible = tbEmployeeName.Text.ToString() == null || tbEmployeeName.Text.ToString() == String.Empty;

            //store the name input for use later
            if (!lblNameError.Visible) { employeeName = tbEmployeeName.Text; }

            lblNumberError.Visible = !Int32.TryParse(tbEmployeeNumber.Text,out employeeNumber);

            lblPayRateError.Visible = !Double.TryParse(tbEmployeePayRate.Text,out payRate);

            //use the error labels as flags and store in an array
            bool[] validInputs = new bool[3];
            validInputs[0] = lblNameError.Visible;
            validInputs[1] = lblNumberError.Visible;
            validInputs[2] = lblPayRateError.Visible;

            //cycle thru the array any true values returns the method and disables the Create button
            foreach (bool value in validInputs) {
                if (value)
                {
                    lblError.Visible = true; btCreate.Enabled = false; return;
                }//end if
            }//end foreach
            lblError.Visible = false;
            btCreate.Enabled = true;
        }//end validateInput

        private void input_TextChanged(object sender, EventArgs e)
        {
            validateInput();
        }//end input_TextChanged

        #endregion validate

        private void btCreate_Click(object sender, EventArgs e)
        {
            //When the Create button is pushed a new ProductinWorker class is made.
            ProductionWorker productionWorker = new ProductionWorker();

            //Its fields  are set 
            productionWorker.Name = employeeName;
            productionWorker.Number = employeeNumber;
            productionWorker.Shift = shift;
            productionWorker.payRate = payRate;

            // then displayed
            tbEmployeeNameClass.Text = productionWorker.Name;
            tbEmployeeNumberClass.Text = productionWorker.Number.ToString();
            tbShiftClass.Text = productionWorker.Shift.ToString();
            tbPayRateClass.Text = productionWorker.payRate.ToString("c");

        }
    }
}
