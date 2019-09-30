/* Michelle Bagnall
 * CITA 210
 * Assignment 4: Magic Date Checker
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            // Catch all input that isn't an integer.
            try
            {
                // cached references
                int monthMin = 1;
                int monthMax = 12;
                int dayMin = 1;
                int dayMax = 31;
                int yearMin = 1;
                int yearMax = 99;

                int month = int.Parse(monthTextBox.Text);
                int day = int.Parse(dayTextBox.Text);
                int year = int.Parse(yearTextBox.Text);

                string monthString = month.ToString();
                string dayString = day.ToString();
                string yearString = year.ToString();

                if (month >= monthMin && month <= monthMax)
                {
                    if (day >= dayMin && day <= dayMax)
                    {
                        if (year >= yearMin && year <= yearMax)
                        {
                            // Determine if the month times the day equals the year.
                            if (month * day == year)
                            {
                                magicNumberLabel.Text = monthString + "/" + dayString + "/" + yearString + " is a magic date!";
                            }
                            // Display message in label.
                            else
                            {
                                magicNumberLabel.Text = monthString + "/" + dayString + "/" + yearString + " is not a magic date.";
                            }
                        }
                        else
                        {
                            MessageBox.Show("That year is out of range.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("That day is out of range.");
                    }
                }
                else
                {
                    MessageBox.Show("That month is out of range.");
                }
            }
            // Display error message when caught.
            catch (Exception)
            {
                MessageBox.Show("That is not a number.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clears all text from text boxes and labels.
            monthTextBox.Text = "";
            dayTextBox.Text = "";
            yearTextBox.Text = "";
            magicNumberLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exits the program
            this.Close();
        }
    }
}
