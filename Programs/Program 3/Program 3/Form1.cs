// A1519
// CIS-199-01
// Program 3
// 11/20/2016

// Using range matching and parallel arrays, takes user input of credit hours and last name and outputs registration time for Spring 2017 at UofL. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class prog3Form : Form
    {
        public prog3Form()
        {
            InitializeComponent();
        }

        // Precondition: Input of valid credit hours (>0) and last name (string); click button
        // Postcondition: Output of registration time
        private void findRegTimeBtn_Click(object sender, EventArgs e)
        {
            const float SENIOR_HOURS = 90;    // Min hours for Senior
            const float JUNIOR_HOURS = 60;    // Min hours for Junior
            const float SOPHOMORE_HOURS = 30; // Min hours for Soph.

            // Array of Senior Registration Dates listed in alphabetic order
            string[] seniorRegistrationSchedule = {"November 4th, 2:00 PM", "November 4th, 4:00 PM", "November 4th, 8:30 AM",
                                                   "November 4th, 10:00 AM", "November 4th, 11:30 AM"};

            // Array of Junior Registration Dates listed in alphabetic order
            string[] juniorRegistrationSchedule = {"November 7th, 2:00 PM", "November 7th, 4:00 PM", "November 7th, 8:30 AM",
                                                   "November 7th, 10:00 AM", "November 7th, 11:30 AM"};
            
            // Array of Sophomore Registration Dates listed in alphabetic order
            string[] sophomoreRegistrationSchedule = {"November 10th, 10:00 AM", "November 10th, 11:30 AM", "November 10th, 2:00 PM", "November 10th, 4:00 PM",
                                                      "November 9th, 8:30 AM", "November 9th, 10:00 AM", "November 9th, 11:30 AM", "November 9th, 2:00 PM",
                                                      "November 9th, 4:00 PM", "November 10th, 8:30 AM"};

            // Array of Freshmen Registration Dates listed in alphabetic order
            string[] freshmenRegistrationSchedule = {"November 14th, 10:00 AM", "November 14th, 11:30 AM", "November 14th, 2:00 PM", "November 14th, 4:00 PM",
                                                     "November 11th, 8:30 AM", "November 11th, 10:00 AM", "November 11th, 11:30 AM", "November 11th, 2:00 PM",
                                                     "November 11th, 4:00 PM", "November 14th, 8:30 AM"};

            // Array of upperclassmen last name chars matched to registration dates
            char[] upperClassLastNameOrder = { 'D', 'I', 'O', 'S', 'Z' };

            // Array of underclassmen last name chars matched to registration dates
            char[] underClassLastNameOrder = { 'B', 'D', 'F', 'I', 'L', 'O', 'Q', 'S', 'V', 'Z' };

            string lastNameStr;       // Entered last name
            char lastNameLetterCh;    // First letter of last name, as char
            float creditHours;        // Entered credit hours
            bool found = false;       // Boolean for parallel array / range matching

            if (float.TryParse(creditHrTxt.Text, out creditHours) && creditHours >= 0) // Valid hours
            {
                lastNameStr = lastNameTxt.Text;
                if (lastNameStr.Length > 0) // Empty string?
                {
                    lastNameLetterCh = lastNameStr[0];   // First char of last name
                    lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                    if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                    {
                        // Juniors and Seniors share same schedule but different days
                        int index = 0;
                        if (creditHours >= JUNIOR_HOURS)
                        {
                            if (creditHours >= SENIOR_HOURS)
                            {
                                while (index <= upperClassLastNameOrder.Length - 1 && !found)
                                {
                                    if (lastNameLetterCh <= upperClassLastNameOrder[index])
                                        found = true;
                                    else
                                        ++index;
                                }

                                if (found)
                                {
                                    RegLbl.Text = seniorRegistrationSchedule[index];
                                }
                            }

                            else // Must be juniors
                            {
                                index = 0;
                                while (index <= upperClassLastNameOrder.Length - 1 && !found)
                                {
                                    if (lastNameLetterCh <= upperClassLastNameOrder[index])
                                        found = true;
                                    else
                                        ++index;
                                }

                                if (found)
                                {
                                    RegLbl.Text = juniorRegistrationSchedule[index];
                                }
                            }

                        }
                        // Sophomores and Freshmen
                        else // Must be soph/fresh
                        {
                            if (creditHours >= SOPHOMORE_HOURS)
                            {
                                index = 0;
                                while (index <= underClassLastNameOrder.Length - 1 && !found)
                                {
                                    if (lastNameLetterCh <= underClassLastNameOrder[index])
                                        found = true;
                                    else
                                        ++index;
                                }

                                if (found)
                                {
                                    RegLbl.Text = sophomoreRegistrationSchedule[index];
                                }

                            }
                            else // must be freshman
                            {
                                index = 0;
                                while (index <= underClassLastNameOrder.Length - 1 && !found)
                                {
                                    if (lastNameLetterCh <= underClassLastNameOrder[index])
                                        found = true;
                                    else
                                        ++index;
                                }

                                if (found)
                                {
                                    RegLbl.Text = freshmenRegistrationSchedule[index];
                                }
                            }


                        }
                    }
                    else // First char not a letter
                        MessageBox.Show("Enter valid last name!");
                }
                else // Empty textbox
                    MessageBox.Show("Enter a last name!");
            }
            else // Can't parse credit hours
                MessageBox.Show("Please enter valid credit hours earned!");
        }
    }
}
