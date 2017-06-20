using System;
using System.Windows.Forms;

namespace RandomNumberGuessingGame
{
    public partial class randomNumberGuessingGameForm : Form
    {
        // globals
       private Random random = new Random();

       private int Number = 0;

       private int guessCount = 0;

        public randomNumberGuessingGameForm()
        {
            // this places the first random number of the game at the start of the app
            this.Number = random.Next(100) + 1;

            InitializeComponent();
        } // end randomNumberGuessingGameForm constructer 

        private void btGuess_Click(object sender, EventArgs e)
        {
            //Button checks if guess was correct or not.

            //input valadation logic
            int input = 0;

            bool valiad = Int32.TryParse(tbGuessInput.Text.ToString(), out input)
                && input <= 100 && input >= 1;

            lbError.Visible = !valiad;


            // if valadation logic returns true. find if guess is correct. if not display message and return method
            if (valiad) {

                if (input > Number)
                {
                    lbGuessState.ForeColor = System.Drawing.Color.Red;
                    guessCount++;
                    lbGuessState.Text = "Too High, try again" + "\n" + "Number of Guesses " + guessCount + ".";
                    
                    return;
                }// end  if (input > Number)
                else if (input < Number)
                {
                    lbGuessState.ForeColor = System.Drawing.Color.Red;
                    guessCount++;
                    lbGuessState.Text = "Too Low, try again" + "\n" + "Number of Guesses " + guessCount + ".";
                    
                    return;
                }//end else if (input < Number)

                    lbGuessState.ForeColor = System.Drawing.Color.Green;

                    lbGuessState.Text = "You Win!"+ "\n" + "Number of Guesses "+ guessCount + "." ;

                    this.Number = random.Next(100) + 1;

                    guessCount = 0;

            } //end if (valiad) 
        }//end btGuess_Click
    }//end randomNumberGuessingGameForm
}// end Namespace
