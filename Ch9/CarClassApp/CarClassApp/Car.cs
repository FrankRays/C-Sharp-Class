using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CarClassApp
{
    class Car
    {
        //Fields 
        public int Year { get;}
        public string Make{get;}
        private double Speed;

       public Car(int Year, string Make) {
            //set the make and year with the args and set the speed to 0
            this.Year = Year;
            this.Make = Make;
            Speed = 0.0;

        }//end Car Constructor

         //note i whould like to thread this
        public void Accelerate(Label speedLabel) {
            //Increase the speed of the car and update the label property to simulate a gradual increase of speed

            //the starting rate of simulated Acceleration just some random Division of 5
            double rateOfAccelerateion = 5.0 / 32;

            //save the previous speed
            double oldSpeed = Speed;

            //this saves the previous rate of Acceleration in the while loop
            double previousRate = 0;

            //increase the speed
            Speed += 5;
            
            //loop untell the label property == the Car class speed
            while(!(Speed == oldSpeed)) {

                //increase the previous speed by the curint rate of Acceleration and - by the previous rate
                oldSpeed += rateOfAccelerateion - previousRate;

                //display the label with the new speed
                speedLabel.Text = String.Format("{0:0.00}",oldSpeed) + "mph";

                //use sleep to space out the changes
                Thread.Sleep(200);

                //update the label
                speedLabel.Update();

                //save the curint rate of Accelerateion
                previousRate = rateOfAccelerateion;
                //double the Current rate
                rateOfAccelerateion *= 2;


            }//end while


        }//end Accelerate method

        public void Brake(Label speedLabel) {
            // this uses the same logic as Accelerate just goes -
            if (Speed == 0) return;

            double oldSpeed = Speed;

            Speed -= 5;

            double rateOfBraking = 5.0 / 32;

            double i = 0;


            while (!(Speed == oldSpeed))
            {

                oldSpeed -= rateOfBraking - i;

                speedLabel.Text = String.Format("{0:0.00}", oldSpeed) + "mph";

                Thread.Sleep(200);
                speedLabel.Update();

                i = rateOfBraking;
                rateOfBraking *= 2;


            }//end while
        }//end brake method
    }//end car class
}//end namespace
