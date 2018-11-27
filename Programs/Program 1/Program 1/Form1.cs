// A1519
// Program 1
// Due September 27
// CIS-199 Section1

// This program takes user inputs of square feet to be painted, number of coats to be painted, and the cost of paint per gallon. The program outputs the total
// square feet to be painted, the number of gallons required, the number of hours it will take, the total cost of paint, total cost of labor, and finally the
// total cost.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class prog1 : Form
    {
        public prog1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const float LABOR_PER_HOUR = 12.50f;             // Cost of labor per hour (12.50)
            const float SQUARE_FEET_PER_GALLON = 275f;       // Possible sqr. ft. painted per gallon (275 sqr. ft. per gallon)
            const float HOURS_LABOR_PER_SQR_FT = 8f / 275f;  // Hours of labor per sqr. ft (8 hours per 275 spr. ft.)

            // Converts user string inputs into appropriate variable types
            float fSquareFeet = float.Parse(squareFeetTextBox.Text);
            int intCoats = int.Parse(coatsTextBox.Text);
            float fPaintCost = float.Parse(paintCostTextBox.Text);
           
            float totalSquareFeet = fSquareFeet * (float) intCoats; // Calculates the total square feet to be painted
            float totalGallons = (float)Math.Ceiling(fSquareFeet * intCoats / SQUARE_FEET_PER_GALLON); // Calculates the total gallons used
            float totalHours = totalSquareFeet * HOURS_LABOR_PER_SQR_FT; // Calculates total hours of labor
            float totalCostPaint = totalGallons * fPaintCost; // Calculates total cost of paint
            float totalLaborCost = totalHours * LABOR_PER_HOUR; // Calculates total labor cost
            float totalCost = totalCostPaint + totalLaborCost; // Calculates total cost

            // Converts all calculations into string to be outputted into labels.
            totalSqrFtOutputLabel.Text = totalSquareFeet.ToString("n1");
            totalGallonsOutputLabel.Text = totalGallons.ToString();
            totalHoursOutputLabel.Text = totalHours.ToString("n1");
            totalPaintOutputLabel.Text = totalCostPaint.ToString("c");
            totalLaborOutputLabel.Text = totalLaborCost.ToString("c");
            totalCostOutputLabel.Text = totalCost.ToString("c");

        }

        // Button that clears all text boxes and labels.
        private void clearButton_Click(object sender, EventArgs e)
        {
            squareFeetTextBox.Clear();
            coatsTextBox.Clear();
            paintCostTextBox.Clear();
            totalSqrFtOutputLabel.Text = "";
            totalGallonsOutputLabel.Text = "";
            totalHoursOutputLabel.Text = "";
            totalPaintOutputLabel.Text = "";
            totalLaborOutputLabel.Text = "";
            totalCostOutputLabel.Text = "";
        }

        // Button that exits program.
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
