using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NameSearch
{
    public partial class nameSearchForm : Form
    {
        //global Lists   
        private List<string> Boys;
        private List<string> Girls;
        
        public nameSearchForm()
        {
            //at the start of the form. load the files from resources as strings and convert to lists
            Boys = Properties.Resources.BoyNames.Split(new string[] { "\r\n" }, StringSplitOptions.None).ToList();
            Girls = Properties.Resources.GirlNames.Split(new string[] { "\r\n" }, StringSplitOptions.None).ToList();
            //format all of the names to lower case for easy comparison
            makeLowerCaseList(Boys);
            makeLowerCaseList(Girls);
            //alphabetize both list so a binarySearch can be used later.
            Boys.Sort();
            Girls.Sort();

            InitializeComponent();

            
        }// end nameSearchForm constructor

        #region formating methods
        private void makeLowerCaseList(List<string> names) {
            //formats all of the names in a list to lower case for easy comparison 
            for (int i = 0; i < names.Count; ++i) {
                names[i] = names[i].ToLower();
            }//end for
        }// end makeLowerCaseList

        private string displayUpperCase(List<string> list,int index,int offset) {
            // formats the name to upper case
            return char.ToUpper(list.ElementAt(index + offset)[0]) + list.ElementAt(index + offset).Substring(1);
        }// end displayUpperCase

        private void tbInputName_Enter(object sender, EventArgs e)
        {
            tbInputName.SelectAll();
        }//end tbInputName_Enter
        #endregion formating methods

        private void tbInputName_TextChanged(object sender, EventArgs e)
        {
            //this method checks the user input every time it is changed and displays if the user has a popular name

            // reset the label that displays the search results
            lblSearchResults.Text = "";

            string searchResults;

            //take user input and format to lower case for comparson.
            string input = tbInputName.Text.ToString().ToLower();
            
            // check if input is valid if not just return the method and let the user enter a valid input
            if (input == null|| tbInputName.TextLength < 1) return;

            //check if the user is looking for a boys name or girls name.
            if (rbBoyName.Checked)
            {
                searchResults = nameSearch(Boys, input);
            }//end if(rbBoyName.Checked)
            else
            {
                searchResults = nameSearch(Girls, input);
            }// end else

            //if the searchResults is null the nameSearch has failed to find a name or an approximate match
            if (searchResults == null) return;

            //display the results of the search.
            lblSearchResults.Text = searchResults;


        }//end tbInputName_Enter

        private string nameSearch(List<string> list,string input) {
            // this method searchs for the name in a list using .nets BinarySearch method
            int index = list.BinarySearch(input);
            
            // if the BinarySearch returns a int that is not negative, it has found a match 
            if (index >= 0)
            return displayUpperCase(list, index, 0) + " is a popular name.";

            //if the BinarySearch returns a negative, it has not found a direct match but the negative int is a reverse of the index that is a close approximate match.
            //to make the negative index useful use the ones complement operater.
            index = ~index;
            // using the index with the approximate match, show the user names they could of wanted
            //what is displayed changes on whare the name is on the list.

            //if the approximate match is at the 0 index of the list display only the index at 0 and 1
            if (index == 0)
            return "Did you mean, " + displayUpperCase(list, index, 0) + " or " + displayUpperCase(list, index, 1) + "?";

            //if the approximate match is at the end of the list display the last value and the one before it
            else if (index == list.Count -1)
            return "Did you mean, " + displayUpperCase(list, index, -1) + " or " + displayUpperCase(list, index, 0) + "?";

            //if the approximate match is with in the range of the list, display the values before and after it.
            else if (index < list.Count - 1)
            return "Did you mean, " + displayUpperCase(list, index, -1) + ", " + displayUpperCase(list, index, 0) + " or " + displayUpperCase(list, index, 1) + "?";

            //if the index is out of range return a null this means the BinarySearch could not find a match or a approximate match.
            return null;
        }// end nameSearch Method
    }// end nameSearchForm
}// end namespace
