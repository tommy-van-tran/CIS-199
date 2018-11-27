// A1519
// CIS 199-01
// Lab 9
// 11/29/2016

// Lab that utilizes classes to allow user to update dates on a form.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Date
    {
        // Fields
        private int _month;
        private int _day;
        private int _year;

        // Constructor
        public Date(int m = 0, int d = 0, int y = 0)
        {
            Month = m;
            Day = d;
            Year = y;
        }

        // Month Property
        public int Month
        {
            // Pre-condition: None
            // Post-condition: Returns the month
            get
            {
                return _month;
            }

            // Pre-condition: 1 <= Value <= 12 ; else, set to 1
            // Post-condition: sets month to value
            set
            {
                if (value >= 1 && value <= 12)
                {
                    _month = value;
                }

                else
                {
                    _month = 1;
                }
            }
        }

        // Day Property
        public int Day
        {
            // Pre-condition: None
            // Post-condition: Returns the day
            get
            {
                return _day;
            }

            // Pre-condition: 1 <= Value <= 31 ; else, set to 1
            // Post-condition: sets day to value
            set
            {
                if (value >= 1 && value <= 31)
                {
                    _day = value;
                }

                else
                {
                    _day = 1;
                }
            }
        }

        // Year Property
        public int Year
        {
            // Pre-condition: None
            // Post-condition: Returns the year
            get
            {
                return _year;
            }

            // Pre-condition: Value >= 0 ; else, set to 2000
            // Post-condition: Sets year to value
            set
            {
                if (value >= 0)
                {
                    _year = value;
                }

                else
                {
                    _year = 2000;
                }
            }

        }

        // Pre-condition: Valid integers for month, date and year
        // Post-condition: Turns month, date and year into formatted string. 
        public override string ToString()
        {
            string date;

            date = Month.ToString("D2") + "/" + Day.ToString("D2") + "/" + Year.ToString("D4");

            return date;
        }

    }
}
