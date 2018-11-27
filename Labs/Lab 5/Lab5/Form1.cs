// A1519
// Lab 5
// October 23, 2016
// CIS 199-01

// This lab allows a user to input a beginning and ending integer value and displays a list of the values counted
//out. It also lets the user select from a set of three radio buttons hpw to run this program (while, for, do-while).

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class lab5 : Form
    {
        public lab5()
        {
            InitializeComponent();
        }

        private void runLoopBtn_Click(object sender, EventArgs e)
        { 
            int count;          // Count integer for loops
            int beginningValue; // Beginning integer to start list
            int endingValue;    // Ending integer to end list

            // Parses the integers entered by the user, and see it it's valid / the beginnging value < ending value
            if (int.TryParse(fromTextBox.Text, out beginningValue) && int.TryParse(toTextBox.Text, out endingValue) && beginningValue < endingValue)
            {
                // Performs the loop depending on which radio button is checked by the user
                if (whileRadioBtn.Checked)
                {
                    while (beginningValue <= endingValue)
                    {
                        outputListBox.Items.Add(beginningValue);
                        beginningValue++;
                    }
                }

                else if (forRadioBtn.Checked)
                {
                    for (count = beginningValue; count <= endingValue; count++)
                    {
                        outputListBox.Items.Add(beginningValue);
                        beginningValue++;
                    }
                }

                else if (doWhileRadioBtn.Checked)
                {
                    do
                    {
                        outputListBox.Items.Add(beginningValue);
                        beginningValue++;
                    } while (beginningValue <= endingValue);
                }
                
            }
            
            // Displays error message if values entered by user are not integers
            else
            {
                MessageBox.Show("Please enter an appropriate integer value / make sure the beginning value is less than the ending value!");
            }
        }

        // Clears the list box of items
        private void clearListButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
        }
    }
}
