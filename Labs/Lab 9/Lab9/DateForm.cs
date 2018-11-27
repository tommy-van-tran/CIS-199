// A1519
// CIS 199-01
// Lab 9
// 11/29/2016

// Lab that utilizes classes to allow user to update dates on a form.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class DateForm : Form
    {
        public DateForm()
        {
            InitializeComponent();
        }

        // Set instance variable
        Date Now = new Date(1, 1, 2000);

        // Pre-condition: None
        // Post-condition: Sets date output label to date
        private void DateForm_Load(object sender, EventArgs e)
        {
            dateOutputLbl.Text = Now.ToString();
        }

        // Pre-condition: Integer between 1 and 12
        // Post-condition: Sets the Month of "Now" to month inputted by user
        private void updateMonthButton_Click(object sender, EventArgs e)
        {
            int aMonth; // Set variable to hold the month

            if (int.TryParse(monthTextBox.Text, out aMonth))
            {
                Now.Month = aMonth;
            }

            else
            {
                MessageBox.Show("Please enter a valid numeric month.");
            }

            dateOutputLbl.Text = Now.ToString();
            monthTextBox.Clear();

        }

        // Pre-condition: Integer between 1 and 31
        // Post-condition: Sets the day of "Now" to day inputted by user
        private void updateDayButton_Click(object sender, EventArgs e)
        {
            int aDay; // Set variable to hold the day

            if (int.TryParse(dayTextBox.Text, out aDay))
            {
                Now.Day = aDay;
            }

            else
            {
                MessageBox.Show("Please enter a valid numeric day.");
            }

            dateOutputLbl.Text = Now.ToString();
            dayTextBox.Clear();

        }


        // Pre-condition: Integer >= 0
        // Post-condition: Sets the Year of "Now" to year inputted by user
        private void updateYearButton_Click(object sender, EventArgs e)
        {
            int aYear; // Set variable to hold the Year

            if (int.TryParse(yearTextBox.Text, out aYear))
            {
                Now.Year = aYear;
            }

            else
            {
                MessageBox.Show("Please enter a valid numeric Year.");
            }

            dateOutputLbl.Text = Now.ToString();
            yearTextBox.Clear();
        }
    }
}
