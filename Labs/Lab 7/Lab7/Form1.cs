// A1519
// Lab 7
// November 6, 2016
// CIS-199-01

// This program lets the user type in the number of a month as well as the language (from English, Spanish, and 
// Italian) and the program outputs the name of the month in the selected language.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }

        private void outputBtn_Click(object sender, EventArgs e)
        {
            // Assigns an array of strings of the months in English
            string[] monthsInEnglish = new string[] {"January", "February", "March", "April", "May", "June", "July",
                                                     "August", "September", "October", "November", "December"};

            // Assigns an array of strings of the months in Spanish
            string[] monthsInSpanish = new string[] {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio",
                                                     "Agosto", "Septiembre", "Octubre", "Noviembre", "Deciembre"};

            // Assigns an array of strings of the months in Italian
            string[] monthsInItalian = new string[] {"Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio",
                                                     "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"};
            int monthNumber; // Number entered by user

            // Checks to see if user input is valid
            if (int.TryParse(monthNumberTxtBox.Text, out monthNumber) && monthNumber >= 1 && monthNumber <= 12) {

                int monthIndex = monthNumber - 1; // Turns the month number its index in the array

                if (englishRadioBtn.Checked) 
                {
                    // If English is checked, pulls the index from monthsInEnlish array
                    monthOutputLbl.Text = monthsInEnglish[monthIndex];  
                }

                else if (spanishRadioBtn.Checked)
                {
                    // If Spanish is checked, pulls the index from monthsInSpanish array
                    monthOutputLbl.Text = monthsInSpanish[monthIndex];
                }

                else if (italianRadioBtn.Checked)
                {
                    // If Italian is checked, pulls the index from monthsInItalian array
                    monthOutputLbl.Text = monthsInItalian[monthIndex];
                }
            }

            // MessageBox that will appear if user input is invalid
            else
            {
                MessageBox.Show("Please enter a valid month number (1 = January, 2 = February, etc.)");
            }
        }
    }
}
