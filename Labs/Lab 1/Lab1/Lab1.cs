// A1519
// Lab 1
// 11/07/2016
// CIS 199-01
// This program shows an image of me with my name, followed by three buttons that show my favorite hobbies, book, and movie.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        // This is a photo of me, on the right, with my S.O. on the Walking Bridge.
        private void pictureOfMe_Click(object sender, EventArgs e)
        {

        }

        // This button shows my favorite hobbies.
        private void viewHobbiesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My favorite hobbies are eating at places I've never been, reading, playing videos games and hanging out with my friends.");
        }

        // This button shows my favorite book.
        private void viewBookButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My favorite book is The Name of the Wind, from the Kingkiller Chronicles by Patrick Rothfuss.");
        }

        // This button shows my favorite movie.
        private void viewMovieButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My favorite movie is The Lord of the Rings: The Two Towers.");
        }
    }
}
