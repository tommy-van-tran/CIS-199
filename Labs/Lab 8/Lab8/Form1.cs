// A1519
// Lab 8
// November 13th, 2-16
// CIS-199-01

// This lab inputs user trip distance and outputs ticket price; performed by range matching parallel arrays of trip distance and ticket price

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class lab8Form : Form
    {
        public lab8Form()
        {
            InitializeComponent();
        }

        private void viewPriceBtn_Click(object sender, EventArgs e)
        {
            int[] tripDistanceFloor = { 0, 100, 300, 500 };             // Array that displays the floor distance that matches price range
            decimal[] ticketPrice = { 25.00m, 40.00m, 55.00m, 70.00m }; // Array that displays the ticket prices
            bool found = false;        // Boolean to show whether there was a distance match
            decimal outputPrice = 0m;  // Output price of ticket
            double tripDistance = 0;      // User-inputted trip distance

            int index = tripDistanceFloor.Length - 1; // Turns position of distances into array index positions

            while (index >= 0 && !found)
            {
                if (double.TryParse(distanceTextBox.Text, out tripDistance) && tripDistance >= 0) // Parses user inputs; needs to be greater than 0
                {
                    if (tripDistance >= tripDistanceFloor[index]) // Performs array matching
                    {
                        found = true;
                    }
                    else
                    {
                        --index;
                    }

                    if (found)
                    {
                        outputPrice = ticketPrice[index];
                        priceOutputLbl.Text = outputPrice.ToString();
                        // If found, output price is the price in the position of the array, and displays it in ouput label.
                    }

                }

                else
                {
                    MessageBox.Show("Please enter a valid trip distance."); // Displays message box if data inputted in invalid
                }

            }

        }

        // Button that closes form
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
