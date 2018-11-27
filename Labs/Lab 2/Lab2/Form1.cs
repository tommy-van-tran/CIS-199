// A1519
// Lab 2
// Due Date: September 18t, 2016
// CIS 199 Section 1
// This program takes an input of the user's preffered title and first, middle, and last names
// and outputs it into 6 different formats. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class lab2 : Form
    {
        public lab2()
        {
            InitializeComponent();
        }

        // Labels for TextBoxes

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void middleNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        // TextBoxes

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void middleNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Output controls

        private void fullNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void format1Button_Click(object sender, EventArgs e)
        {
            string fullName; // Declares the string fullName

            // Concatenates the input to format the output for fullName.
            // (Title) (First Name) (Middle Name) (Last Name)
            fullName = titleTextBox.Text + " " + firstNameTextBox.Text + " " + middleNameTextBox.Text + " " + lastNameTextBox.Text;

            // Displays the outputted fullName into the the fullNameLabel control.
            fullNameLabel.Text = fullName;
        }

        private void format2Button_Click(object sender, EventArgs e)
        {
            string fullName; // Declares the string fullName

            // Concatenates the input to format the output for fullName.
            // (First Name) (Middle Name) (Last Name)
            fullName = firstNameTextBox.Text + " " + middleNameTextBox.Text + " " + lastNameTextBox.Text;

            fullNameLabel.Text = fullName;
        }

        private void format3Button_Click(object sender, EventArgs e)
        {
            string fullName; // Declares the string fullName

            // Concatenates the input to format the output for fullName.
            // (First Name) (Last Name)
            fullName = firstNameTextBox.Text + " " + lastNameTextBox.Text;

            fullNameLabel.Text = fullName;
        }

        private void format4Button_Click(object sender, EventArgs e)
        {
            string fullName; // Declares the string fullName

            // Concatenates the input to format the output for fullName.
            // (Last Name), (First Name) (Middle Name), (Title)
            fullName = lastNameTextBox.Text + ", " + firstNameTextBox.Text + " " + middleNameTextBox.Text + ", " + titleTextBox.Text;

            fullNameLabel.Text = fullName;
        }

        private void format5Button_Click(object sender, EventArgs e)
        {
            string fullName; // Declares the string fullName

            // Concatenates the input to format the output for fullName.
            // (Last Name), (First Name) (Middle Name)
            fullName = lastNameTextBox.Text + ", " + firstNameTextBox.Text + " " + middleNameTextBox.Text;

            fullNameLabel.Text = fullName;
        }

        private void format6Button_Click(object sender, EventArgs e)
        {
            string fullName; // Declares the string fullName

            // Concatenates the input to format the output for fullName.
            // (Last Name), (First Name)
            fullName = lastNameTextBox.Text + ", " + firstNameTextBox.Text;

            fullNameLabel.Text = fullName;
        }

        private void clearTextBoxesButton_Click(object sender, EventArgs e)
        {
            // Clears all of the text in each of the textboxes
            firstNameTextBox.Text = "";
            middleNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            titleTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the form
            this.Close();
        }
    }
}
