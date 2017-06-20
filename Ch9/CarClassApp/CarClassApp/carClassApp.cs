using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarClassApp
{
    /// <summary>
    /// Devloper: Sebastian Hoer
    /// Date: 3/31/2017
    ///
    /// </summary>
    public partial class carClassApp : Form
    {
        //Creating the car object from the car class
        Car Ford = new Car(1990, "Ford");

        public carClassApp()
        {
            InitializeComponent();
            
            //geting the make and year from the car object 
            lblMake.Text = "Make: " + Ford.Make;

            lblyear.Text = "Year: " + Ford.Year;
            
        }//end carClassapp constructor

        private void btAccelrate_Click(object sender, EventArgs e)
        {
            // Accelrate button method calls the Car Object Accelerate method
            Ford.Accelerate(lblSpeed);
        }//end btAccelrate_Click

        private void btBrake_Click(object sender, EventArgs e)
        {
            // Brake button method calls the Car Object Brake method
            Ford.Brake(lblSpeed);
        }//end btBrake_Click
    }
}
