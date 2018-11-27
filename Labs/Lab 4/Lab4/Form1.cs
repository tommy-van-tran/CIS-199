// A1519
// Lab 4
// October 2, 2016
// CIS 199 - Section 01

// This lab allows the user to enter a GPA and test score. They will be accepted into a hypothetical university if:
// their GPA is 3.0 and higher and test score is 60 and higher, OR, GPA is less than 3.0 and test score is 80 and 
// higher. For every entry, there is a counter that displays the number of entries accepted and rejected.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class lab4Form : Form
    {
        public lab4Form()
        {
            InitializeComponent();
        }

        float gpa;            // High school GPA
        int testScore;        // Admission test score
        int numberAccepted;   // Counter for number of people accepted
        int numberRejected;   // Counter for number of people rejected

        private void viewResultBtn_Click(object sender, EventArgs e)
        {
            // Checks if data is able to be parsed, and carries out the conditionals
            if (float.TryParse(gpaTextBox.Text, out gpa) && int.TryParse(testScoreTextBox.Text, out testScore))
            {
                // Checks to see if the scores are eligible for passing
                if ((gpa >= 3.0 && testScore >= 60) || (gpa < 3.0 && testScore >= 80)) { 
                    MessageBox.Show("Accept!");
                    numberAccepted++; // Adds 1 to the counter for accepted scores
                } 
                else
                {
                    MessageBox.Show("Reject");
                    numberRejected++; // Adds 1 to the counter for the rejected scores
                }
            }
            else
            {
                MessageBox.Show("Please enter in valid data for the text boxes!");
            }

            // Turns the counters into text labels for users to see
            acceptedOutputLbl.Text = "Number of applicants accepted: " + numberAccepted.ToString();
            rejectedOutputLbl.Text = "Number of applicants rejected: " + numberRejected.ToString();
        }

        // Button that clears the text boxes
        private void clearBtn_Click(object sender, EventArgs e)
        {
            gpaTextBox.Clear();
            testScoreTextBox.Clear();
        }

        // Exits application
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }


}
