// A1519
// Lab 3
// Due Date: September 25th, 2016
// CIS-199 Section 01

// This program takes the price of a meal from the user and returns three outputs: the tip total of a low, medium,
// and high rate. The tip rates have a default rate of 15, 18 and 20 percent but the user is able to change those in
// the Lab 3 load event handler.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }

        // Variable Declarations
        decimal lowTipRate, mediumTipRate, highTipRate; // Declare decimal variables for low, medium and high tip rates
        decimal mealPrice; // Declares the decimal variable for the meal for the price entered by user

        // Lab 3 Load Event Handler
        private void Lab3_Load(object sender, EventArgs e)
        {
            // Assigns the tip rates. The default is 15% for low, 18% for medium, and 20% for high. To change the rates,
            // simply change the values that are assigned to the tip rates.
            lowTipRate = 0.15m; 
            mediumTipRate = 0.18m;
            highTipRate = 0.20m;

            // Inserts text in the text labels to that of the values assigned to the tip rates in a percent format. 
            // The text labels will update if the user changes the tip rates.
            lowTipRateLabel.Text = lowTipRate.ToString("p");
            mediumTipRateLabel.Text = mediumTipRate.ToString("p");
            highTipRateLabel.Text = highTipRate.ToString("p");
        }

        private void pricePromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void mealPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
         private void lowTipRateLabel_Click(object sender, EventArgs e)
        {

        }

        private void mediumTipRateLabel_Click(object sender, EventArgs e)
        {

        }

        private void highTipRateLabel_Click(object sender, EventArgs e)
        {

        }

        // Output labels and calculations

        private void lowTipRateOutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void mediumTipRateOutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void highTipRateOutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateTipButton_Click(object sender, EventArgs e)
        {
            decimal lowTipResult, mediumTipResult, highTipResult; // Declares the decimal variables for the calcuations for each of the tip results
            
            // Changes the meal price from text to decimal
            mealPrice = decimal.Parse(mealPriceTextBox.Text);
         
            // Performs the calculations for each of the tip rates
            lowTipResult = mealPrice * lowTipRate;
            mediumTipResult = mealPrice * mediumTipRate;
            highTipResult = mealPrice * highTipRate;

            // Changes the results of the tip calculations as strings to be viewed on the output labels
            lowTipRateOutputLabel.Text = lowTipResult.ToString("c");
            mediumTipRateOutputLabel.Text = mediumTipResult.ToString("c");
            highTipRateOutputLabel.Text = highTipResult.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
