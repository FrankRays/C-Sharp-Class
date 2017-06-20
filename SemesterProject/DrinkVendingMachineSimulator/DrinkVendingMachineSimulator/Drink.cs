
using System.Windows.Forms;

namespace DrinkVendingMachineSimulator
{
    
    class Drink {

        
        private Drink(string name) {

            _Name = name;

        }//end constructor

        public static void Create(params Button[] Buttons) {
            //creates 6 drink objects and assigns to the buttons using tags 
            Drink[] drinks = new Drink[Buttons.Length];

            for (int i = 0; i < drinks.Length; ++i)
            {

                drinks[i] = new Drink(Buttons[i].Text);

                Buttons[i].Tag = drinks[i];

            }// end for loop

            //grape soda up charge by 50 cents
            drinks[0].Price += .50m;
            //cream soda up charge by 50 cents
            drinks[2].Price += .50m;

        }//end Create method

        //fields and propertys
        private string _Name;
        public string Name{
            get { return _Name; }
        }//end 

        private decimal _Price = 1.00m;
        public decimal Price {
            get { return _Price; }
            set { _Price = value; }
        }//end

        private int _Stock = 20;
        public int Stock
        {
             get{ return _Stock; }
            set { _Stock = value; }
        }//end

        //the selectedDrink static field and its accessors  
        private static Drink selectedDrink = null;

        public void Select()
        {
            selectedDrink = this;
        }//end

        public static Drink Selected()
        {
            return selectedDrink;
        }//end
        public static void Clear()
        {
            selectedDrink = null;
        }//end
    }
}
