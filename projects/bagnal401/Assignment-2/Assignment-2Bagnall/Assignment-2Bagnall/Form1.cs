using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2Bagnall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            firstNameTextBox.Text = "";
            middleNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            titleTextBox.Text = "";

        }

        private void TitleFullNameButton_Click(object sender, EventArgs e)
        {
            nameOutputLabel.Text = titleTextBox.Text + " " + firstNameTextBox.Text + " " + middleNameTextBox.Text + " " + lastNameTextBox.Text;
        }

        private void FullNameButton_Click(object sender, EventArgs e)
        {
            nameOutputLabel.Text = firstNameTextBox.Text + " " + middleNameTextBox.Text + " " + lastNameTextBox.Text;
        }

        private void FirstLastNameButton_Click(object sender, EventArgs e)
        {
            nameOutputLabel.Text = firstNameTextBox.Text + " " + lastNameTextBox.Text;
        }

        private void LastNameTitleButton_Click(object sender, EventArgs e)
        {
            nameOutputLabel.Text = lastNameTextBox.Text + ", " + firstNameTextBox.Text + " " + middleNameTextBox.Text + ", " + titleTextBox.Text;
        }

        private void LastFirstMiddleNameButton_Click(object sender, EventArgs e)
        {
            nameOutputLabel.Text = lastNameTextBox.Text + ", " + firstNameTextBox.Text + " " + middleNameTextBox.Text;
        }

        private void LastFirstNameButton_Click(object sender, EventArgs e)
        {
            nameOutputLabel.Text = lastNameTextBox.Text + ", " + firstNameTextBox.Text;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            nameOutputLabel.Text = "Your name will display here!";
            firstNameTextBox.Text = "";
            middleNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            titleTextBox.Text = "";
        }
    }
}
