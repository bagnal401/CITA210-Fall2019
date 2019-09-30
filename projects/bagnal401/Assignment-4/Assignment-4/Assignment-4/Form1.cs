/* Michelle Bagnall
 * CITA 210
 * Assignment 4: Roman Numeral Converter
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

namespace Assignment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            // Catch input that isn't an integer.
            try
            {
                // Cached variables.
                \int romanNumeral;

                // 
                romanNumeral = int.Parse(romanNumeralTextBox.Text);

                // Using a swwitch to determine which Roman numeral to display.
                switch (romanNumeral)
                {
                    case 1:
                        romanNumeralLabel.Text = "I";
                        break;
                    case 2:
                        romanNumeralLabel.Text = "II";
                        break;
                    case 3:
                        romanNumeralLabel.Text = "III";
                        break;
                    case 4:
                        romanNumeralLabel.Text = "IV";
                        break;
                    case 5:
                        romanNumeralLabel.Text = "V";
                        break;
                    case 6:
                        romanNumeralLabel.Text = "VI";
                        break;
                    case 7:
                        romanNumeralLabel.Text = "VII";
                        break;
                    case 8:
                        romanNumeralLabel.Text = "VIII";
                        break;
                    case 9:
                        romanNumeralLabel.Text = "IX";
                        break;
                    case 10:
                        romanNumeralLabel.Text = "X";
                        break;
                    // When the number the user puts in is out of range, this message will display.
                    default:
                        MessageBox.Show("That number is out of range.");
                        break;
                }
            }
            // Displays error message.
            catch (Exception)
            {
                MessageBox.Show("That is not a number.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clears text from text box and label.
            romanNumeralTextBox.Text = "";
            romanNumeralLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Closes the program.
            this.Close();
        }
    }
}
