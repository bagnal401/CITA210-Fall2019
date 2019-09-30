using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateRevenueButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Storing seat prices for classes A, B, and C.
                int classAPrice = 15;
                int classBPrice = 12;
                int classCPrice = 9;

                // Converting text box strings to intergers for calculating revenue.
                int classA = int.Parse(classATextBox.Text);
                int classB = int.Parse(classBTextBox.Text);
                int classC = int.Parse(classCTextBox.Text);

                // Calculate revenue for each seat class and the total revenue.
                float aRevenue = classA * classAPrice;
                float bRevenue = classB * classBPrice;
                float cRevenue = classC * classCPrice;
                float totalRevenue = aRevenue + bRevenue + cRevenue;

                // Display revenue for each seat class and the total revenue.
                classALabel.Text = aRevenue.ToString();
                classBLabel.Text = bRevenue.ToString();
                classCLabel.Text = cRevenue.ToString();
                totalRevenueLabel.Text = totalRevenue.ToString();
            }
            catch (Exception ex)
            {
                // Display an error message if input is invalid.
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            classATextBox.Text = "";
            classBTextBox.Text = "";
            classCTextBox.Text = "";
            classALabel.Text = "";
            classBLabel.Text = "";
            classCLabel.Text = "";
            totalRevenueLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
