// A1519
// Program 2
// October 16, 2016
// CIS 199-01

// This program inputs credit hours and a last name, and outputs the date and time of the earliest registration
// time (using UofL Spring 2017 registration times).

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog2
{
    public partial class Prog4 : Form
    {
        public Prog4()
        {
            InitializeComponent();
        }
        
        private void viewResultsBtn_Click(object sender, EventArgs e)
        {
            bool FRESHMAN = true, SOPHOMORE = true, JUNIOR = true, SENIOR = true; // Assigns boolean values to test for each class of students
            float CREDIT_HOURS; // Assigns credit hours
            string LAST_NAME = lastNameTextBox.Text; // Assigns a last name string 
            string LAST_NAME_LOW = LAST_NAME.ToLower(); // Assigns a last name with all lowercase for easier testing
            char LAST_NAME_CHAR = LAST_NAME_LOW[0]; // Assigns char from first character of the last name

            // Tests to see if inputs are valid
            if ((float.TryParse(creditHoursTextBox.Text, out CREDIT_HOURS) && CREDIT_HOURS >= 0) && char.IsLetter(lastNameTextBox.Text[0]))
            {

                // Assigns the class standing (Senior, Junior, Sophomore or Freshman) based on inputted credit hours
                if (CREDIT_HOURS >= 90) 
                {
                    SENIOR = true;
                    JUNIOR = false;
                    SOPHOMORE = false;
                    FRESHMAN = false;
                }
                else if (CREDIT_HOURS < 90 && CREDIT_HOURS >= 60)
                {
                    JUNIOR = true;
                    SENIOR = false;
                    SOPHOMORE = false;
                    FRESHMAN = false;
                }
                else if (CREDIT_HOURS < 60 && CREDIT_HOURS >= 30)
                {
                    SOPHOMORE = true;
                    SENIOR = false;
                    JUNIOR = false;
                    FRESHMAN = false;
                }
                else if (CREDIT_HOURS < 30 && CREDIT_HOURS >=0)
                {
                    FRESHMAN = true;
                    SENIOR = false;
                    JUNIOR = false;
                    SOPHOMORE = false;
                }

                // Based on class standing and first char of last name, outputs the earliest registration time 
                if (SENIOR)
                {
                    if (LAST_NAME_CHAR >= 'j' && LAST_NAME_CHAR <= 'o')
                    {
                        registrationOutputLbl.Text = "Friday, November 4, 8:30 AM";
                    }
                    else if (LAST_NAME_CHAR >= 'p' && LAST_NAME_CHAR <= 's')
                    {
                        registrationOutputLbl.Text = "Friday, November 4, 10:00 AM";
                    }
                    else if (LAST_NAME_CHAR >= 't' && LAST_NAME_CHAR <= 'z')
                    {
                        registrationOutputLbl.Text = "Friday, November 4, 11:30 AM";
                    }
                    else if (LAST_NAME_CHAR >= 'a' && LAST_NAME_CHAR <= 'd')
                    {
                        registrationOutputLbl.Text = "Friday, November 4, 2:00 PM";
                    }
                    else if (LAST_NAME_CHAR >= 'e' && LAST_NAME_CHAR <= 'i')
                    {
                        registrationOutputLbl.Text = "Friday, November 4, 4:00 PM";
                    }
                }


                else if (JUNIOR)
                {
                    if (LAST_NAME_CHAR >= 'j' && LAST_NAME_CHAR <= 'o')
                    {
                        registrationOutputLbl.Text = "Monday, November 7, 8:30 AM";
                    }
                    else if (LAST_NAME_CHAR >= 'p' && LAST_NAME_CHAR <= 's')
                    {
                        registrationOutputLbl.Text = "Monday, November 7, 10:00 AM";
                    }
                    else if (LAST_NAME_CHAR >= 't' && LAST_NAME_CHAR <= 'z')
                    {
                        registrationOutputLbl.Text = "Monday, November 7, 11:30 AM";
                    }
                    else if (LAST_NAME_CHAR >= 'a' && LAST_NAME_CHAR <= 'd')
                    {
                        registrationOutputLbl.Text = "Monday, November 7, 2:00 PM";
                    }
                    else if (LAST_NAME_CHAR >= 'e' && LAST_NAME_CHAR <= 'i')
                    {
                        registrationOutputLbl.Text = "Monday, November 7, 4:00 PM";
                    }
                }

                    if (SOPHOMORE)
                    {
                        if (LAST_NAME_CHAR >= 'j' && LAST_NAME_CHAR <= 'l')
                        {
                            registrationOutputLbl.Text = "Wednesday, November 9, 8:30 AM";
                        }
                        else if (LAST_NAME_CHAR >= 'm' && LAST_NAME_CHAR <= 'o')
                        {
                            registrationOutputLbl.Text = "Wednesday, November 9,, 10:00 AM";
                        }
                        else if (LAST_NAME_CHAR >= 'p' && LAST_NAME_CHAR <= 'q')
                        {
                            registrationOutputLbl.Text = "Wednesday, November 9, 11:30 AM";
                        }
                        else if (LAST_NAME_CHAR >= 'r' && LAST_NAME_CHAR <= 's')
                        {
                            registrationOutputLbl.Text = "Wednesday, November 9, 2:00 PM";
                        }
                        else if (LAST_NAME_CHAR >= 't' && LAST_NAME_CHAR <= 'v')
                        {
                            registrationOutputLbl.Text = "Wednesday, November 9, 4:00 PM";
                        }
                        else if (LAST_NAME_CHAR >= 'w' && LAST_NAME_CHAR <= 'z')
                        {
                            registrationOutputLbl.Text = "Thursday, November 10, 8:30 AM";
                        }
                        else if (LAST_NAME_CHAR >= 'a' && LAST_NAME_CHAR <= 'b')
                        {
                            registrationOutputLbl.Text = "Thursday, November 10, 10:00 AM";
                        }
                        else if (LAST_NAME_CHAR >= 'c' && LAST_NAME_CHAR <= 'd')
                        {
                            registrationOutputLbl.Text = "Thursday, November 10, 11:30 AM";
                        }
                        else if (LAST_NAME_CHAR >= 'e' && LAST_NAME_CHAR <= 'f')
                        {
                            registrationOutputLbl.Text = "Thursday, November 10, 2:00 PM";
                        }
                        else if (LAST_NAME_CHAR >= 'g' && LAST_NAME_CHAR <= 'h')
                        {
                            registrationOutputLbl.Text = "Thursday, November 10, 4:00 PM";
                        }
                    }

                    if (FRESHMAN)
                    {
                        if (LAST_NAME_CHAR >= 'j' && LAST_NAME_CHAR <= 'l')
                        {
                            registrationOutputLbl.Text = "Friday, November 11, 8:30 AM";
                        }
                        else if (LAST_NAME_CHAR >= 'm' && LAST_NAME_CHAR <= 'o')
                        {
                            registrationOutputLbl.Text = "Friday, November 11, 10:00 AM";
                        }
                        else if (LAST_NAME_CHAR >= 'p' && LAST_NAME_CHAR <= 'q')
                        {
                            registrationOutputLbl.Text = "Friday, November 11, 11:30 AM";
                        }
                        else if (LAST_NAME_CHAR >= 'r' && LAST_NAME_CHAR <= 's')
                        {
                            registrationOutputLbl.Text = "Friday, November 11, 2:00 PM";
                        }
                        else if (LAST_NAME_CHAR >= 't' && LAST_NAME_CHAR <= 'v')
                        {
                            registrationOutputLbl.Text = "Friday, November 11, 4:00 PM";
                        }
                        else if (LAST_NAME_CHAR >= 'w' && LAST_NAME_CHAR <= 'z')
                        {
                            registrationOutputLbl.Text = "Monday, November 14, 8:30 AM";
                        }
                        else if (LAST_NAME_CHAR >= 'a' && LAST_NAME_CHAR <= 'b')
                        {
                            registrationOutputLbl.Text = "Monday, November 14, 10:00 AM";
                        }
                        else if (LAST_NAME_CHAR >= 'c' && LAST_NAME_CHAR <= 'd')
                        {
                            registrationOutputLbl.Text = "Monday, November 14, 11:30 AM";
                        }
                        else if (LAST_NAME_CHAR >= 'e' && LAST_NAME_CHAR <= 'f')
                        {
                            registrationOutputLbl.Text = "Monday, November 14, 2:00 PM";
                        }
                        else if (LAST_NAME_CHAR >= 'g' && LAST_NAME_CHAR <= 'h')
                        {
                            registrationOutputLbl.Text = "Monday, November 14, 4:00 PM";
                        }
                    }
                }
            
            // Tests to see if fields are left blank (doesn't work for some reason)
            else if (string.IsNullOrWhiteSpace(creditHoursTextBox.Text) || char.IsWhiteSpace(LAST_NAME_CHAR))
            {
                MessageBox.Show("Please enter a non-zero number for credit hours and a valid last name.");
            }

            // If inputs are invalid, show message box
            else
            {
                MessageBox.Show("Please enter a non-zero number for credit hours and a valid last name.");
            }
        }

        // Button that clears form
        private void clearFormBtn_Click(object sender, EventArgs e)
        {
            creditHoursTextBox.Clear();
            lastNameTextBox.Clear();
            registrationOutputLbl.Text = "";
        }

        // Button that closes form
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
