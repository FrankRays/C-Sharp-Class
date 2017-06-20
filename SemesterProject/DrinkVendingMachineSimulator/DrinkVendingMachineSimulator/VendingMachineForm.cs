using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DrinkVendingMachineSimulator
{

    /// <summary>
    /// Devloper: sebastian hoer
    /// date: 4/27/17
    /// program: DrinkVendingMachineSimulator
    /// </summary>
    public partial class VendingMachineForm : Form
    {
        //globals 
        // TotalSales used in bt_Click funtion
        private decimal TotalSales = 0m;

        public VendingMachineForm()
        {
            
            InitializeComponent();

            //the static method Create creates 6 drink objects and assigns to the buttons using tags  
            Drink.Create(btGrapeSoda, btLemonLime, btCreamSoda, btRootBeer, btCola, btWater);
            
            //method to set vending machine display on start up
            setListBoxMessage("<- Please", "<- select", "<- a drink");


        }//end constructor

        private void bt_Click(object sender, EventArgs e)
        {

            //the bt_Click event handler handles all button clicks


            //cast the sender object to a button object
            //the only controls with the bt_Click mehtod are only buttons 
            Button button = (Button)sender;
            
            //use the button text with a switch to select the right actions for that button
            // all of the drink buttons share the same actions so the default case handles all of them. 
            switch (button.Name) {
                
                //the vend button logic
                case "btVend":
                    //if the Drink hasnt been selected display the message Please select a drink and return the mehtod
                    if (Drink.Selected() == null) {setListBoxMessage("<- Please", "<- select", "<- a drink"); return; }

                    //if the Drink selectied is out of stock display the message Drink Out of Order and return the mehtod
                    if (Drink.Selected().Stock == 0) {setListBoxMessage("<- Drink", "<- Out of Order", "<- Try another"); return; }

                    // if the drink is in stock take one from the stock, update the total sales and
                    //display the drink info and current total Sales
                    Drink.Selected().Stock -= 1;

                    TotalSales += Drink.Selected().Price;

                    setListBoxMessage(Drink.Selected().Name, Drink.Selected().Price.ToString("c"), "Stock: " + Drink.Selected().Stock.ToString());

                    tbTotalSales.Text = "Total Sales: " + TotalSales.ToString("c");

                    break;


                case "btCancel":
                    //Cancle button displays the message Please select a drink and clears the selected drink
                    setListBoxMessage("<- Please", "<- select", "<- a drink");

                    Drink.Clear();

                    break;


                default:
                    //default handles all of the drink buttons

                    //cast the button tag to the drink object and call the Select mehtod to set the selected drink
                     ((Drink)button.Tag).Select();

                    //if the Drink selectied is out of stock display the message Drink Out of Order and return the mehtod
                    if (Drink.Selected().Stock == 0) { setListBoxMessage("<- Drink", "<- Out of Order", "<- Try another"); return; }

                    //if the drink is in stock display the drink info
                    setListBoxMessage(Drink.Selected().Name, Drink.Selected().Price.ToString("c"), "Stock: " + Drink.Selected().Stock.ToString());

                    break;


            }//end method bt_Click
        }
        private void setListBoxMessage(params string[] Message)
        {
            //this mehtod handles the list box display 
            List<string> ListBoxMessage = new List<string>();

            foreach (string message in Message) {

                ListBoxMessage.Add(message);
            }//end foreach

            lbInfo.DataSource = ListBoxMessage;

        }//end setListBoxMessage method
    }//end class VendingMachineForm
}// end namespace
