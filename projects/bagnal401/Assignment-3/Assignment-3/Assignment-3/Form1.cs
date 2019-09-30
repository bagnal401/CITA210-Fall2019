using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FahrenheitButton_Click(object sender, EventArgs e)
        {
            float num = float.Parse(temperatureTextBox.Text);
            float fahrenheit = (num * 9 / 5) + 32;

            temperatureLabel.Text = fahrenheit.ToString();

        }

        private void CelsiusButton_Click(object sender, EventArgs e)
        {
            float num = float.Parse(temperatureTextBox.Text);
            float celcius = (num - 32) * 5 / 9;

            temperatureLabel.Text = celcius.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            temperatureLabel.Text = "Answer will appear here!";
            temperatureTextBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
