/* Michelle M. Bagnall
 * CITA 210: Visual Programming & Development Tools
 * Assignment 1: Creating a Latin-to-English translator app for three words: sinister, medium, and dexter.
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

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        // Form1 calls the InitializeComponent method to start the app.
        public Form1()
        {
            InitializeComponent();
        }

        // SinisterButton_Click will translate the Latin word "Sinister" to the English word "Left" when the button is clicked.
        private void SinisterButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Left"; // Displays "Left" in the translationLabel control.
        }

        // MediumButton_Click will translate the Latin word "Medium" to the English word "Center" when the button is clicked.
        private void MediumButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Center"; // Displays "Center" in the translationLabel control.
        }

        // DexterButton_Click will translate the Latin word "Dexter" to the English word "Right" when the button is clicked.
        private void DexterButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Right"; // Displays "Right" in the translationLabel control.
        }
    }
}
