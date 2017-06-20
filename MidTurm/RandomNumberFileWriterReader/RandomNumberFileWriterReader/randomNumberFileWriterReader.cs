using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
/// <summary>
///Program: RandomNumberFileWriterReader
///Devloper: Sebastian Hoer
///Date: 2/16/2017
///Description: An application that writes and reads random numbers to a file.
/// </summary>


namespace RandomNumberFileWriterReader
{
    public partial class randomNumberFileWriterReader : Form
    {
        //Globals
        private Random random;
        private List<int> randomNumbers;
        //bool flag for input validation on the generate text box
        private bool validInputAmountRandoms;
        //the amount of randoms to be generated
        private int InputAmountRandoms;
        //file name string use for displaying and use in save file option
        private string fileName;
        

        public randomNumberFileWriterReader()
        {
            // initialize global varables 
            this.random = new Random();
            this.randomNumbers = new List<int>();
            this.validInputAmountRandoms = true;
            this.InputAmountRandoms = 0;
            InitializeComponent();
            //when the program is first opened the save file opion is disabled.
            saveToolStripMenuItem.Enabled = false;
        }//end randomNumberFileWriterReader constructors 

        private void btGenerateNumbers_Click(object sender, EventArgs e)
        {
            //Handles the Generate button click, generates a list of Random numbers.
            if (validInputAmountRandoms)
            {
                //before generateing randoms the previons list of randoms is cleared
                randomNumbers.Clear();


                for (int i = 0; i < InputAmountRandoms; ++i)
                {
                    randomNumbers.Add(random.Next(100) + 1);
                }// for (int i = 0; i < InputAmountRandoms; ++i)


                //refresh by using null and then set the data source of lbControl to the list with the new randoms
                lbControl.DataSource = null;
                lbControl.DataSource = randomNumbers;
            }//end if (validInputAmountRandoms)
        }//end btGenerateNumbers_Click

        private void tbNumberOfRandoms_TextChanged(object sender, EventArgs e)
        {
            //Checks if the user input is a whole number and prevents invalid numbers from being used.
            validInputAmountRandoms = Int32.TryParse(tbNumberOfRandoms.Text.ToString(), out InputAmountRandoms)&& InputAmountRandoms > 1;

            //disables the Generate button on invalid input and shows error label.
            lblError.Visible = !validInputAmountRandoms;
            btGenerateNumbers.Enabled = validInputAmountRandoms;
        }//end tbNumberOfRandoms_TextChanged

        private void btClear_Click(object sender, EventArgs e)
        {
            //clears the list of random numbers
            lbControl.DataSource = null;
            randomNumbers.Clear();
        }//end btClear_Click

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Handles the saveAs file menu option, saves the genrated numbers to a txt file.

            // Set the Default extension  to a text file ".txt"
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;
            try
            {
                //open save file dialog and receve input 
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // open a Stream Writer using the File and file path input from save file dialog
                    using (StreamWriter outputFile = File.CreateText(saveFileDialog1.FileName))
                    {
                        //loop thru the list of randoms and write to the file
                        for (int i = 0; i < randomNumbers.Count; i++)
                        {
                            outputFile.WriteLine(randomNumbers.ElementAt(i));
                        }//end for(int i = 0; i < randomNumbers.Count; i++)
                        outputFile.Close();
                    }//end using


                    //saves the file name title
                    fileName = saveFileDialog1.FileName;
                    //enable the save option in the file menu.
                    enableSave();
                    //display the the file name in the 
                    this.Text = saveFileDialog1.FileName + " - Random Number File Writer Reader";
                }//end if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            }//end try
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }//end catch
        }//end saveAsToolStripMenuItem_Click

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Handles the open file option
            //Opens a exising file.
            try
            {
                //open the open file dialog and receve input 
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Clear the list of previous randoms 
                    randomNumbers.Clear();

                    // open a reader using the input from the open file dialog
                    using (StreamReader inputFile = File.OpenText(openFileDialog1.FileName))
                    {
                        //read the data from the flie and add to the list 
                        while (!inputFile.EndOfStream)
                        {

                            randomNumbers.Add(Int32.Parse(inputFile.ReadLine()));

                        }//end while
                    }//end using
                    

                    // copy the name of the file display in title 
                    fileName = openFileDialog1.FileName;
                    this.Text = openFileDialog1.FileName + " - Random Number File Writer Reader";
                    //refresh the lbcontrol
                    lbControl.DataSource = null;
                    lbControl.DataSource = randomNumbers;
                    //enable the save opiton in the file menu
                    enableSave();
                }//end if (openFileDialog1.ShowDialog() == DialogResult.OK)

            }//end try
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }// end catch


        }// end openToolStripMenuItem

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //handles the click for the save menu option. saves to a exising file.
            try
            {
                //open a Stream writer using the saved fileName
                using (StreamWriter outputFile = File.CreateText(fileName))
                {
                    // Write new randoms from list to the file
                    for (int i = 0; i < randomNumbers.Count; i++)
                    {
                        outputFile.WriteLine(randomNumbers.ElementAt(i));
                    }//end for
                    outputFile.Close();
                }// end using
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }// end catch
        }//end saveToolStripMenuItem_Click

        private void enableSave() {
            //Enables the save funcuion in the File menu
            // check that the fileName is set
            if (!(fileName == null))
            {
                //check that the file exists
                if (File.Exists(fileName)) {

                    saveToolStripMenuItem.Enabled = true;

                }// end  if (File.Exists(fileName))
            }//end if (!(fileName == null))
        } // end enableSave

    }// end randomNumberFileWriterReader
}//end namespace
