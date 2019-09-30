namespace Assignment_2Bagnall
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.nameOutputLabel = new System.Windows.Forms.Label();
            this.titleFullNameButton = new System.Windows.Forms.Button();
            this.fullNameButton = new System.Windows.Forms.Button();
            this.firstLastNameButton = new System.Windows.Forms.Button();
            this.lastNameTitleButton = new System.Windows.Forms.Button();
            this.lastFirstMiddleNameButton = new System.Windows.Forms.Button();
            this.lastFirstNameButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your frist name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your middle name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter your last name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter your preferred title:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(169, 18);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(169, 40);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(169, 63);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(169, 87);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 7;
            // 
            // nameOutputLabel
            // 
            this.nameOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOutputLabel.Location = new System.Drawing.Point(15, 125);
            this.nameOutputLabel.Name = "nameOutputLabel";
            this.nameOutputLabel.Size = new System.Drawing.Size(254, 23);
            this.nameOutputLabel.TabIndex = 8;
            this.nameOutputLabel.Text = "Your name will display here!";
            this.nameOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleFullNameButton
            // 
            this.titleFullNameButton.Location = new System.Drawing.Point(12, 166);
            this.titleFullNameButton.Name = "titleFullNameButton";
            this.titleFullNameButton.Size = new System.Drawing.Size(84, 52);
            this.titleFullNameButton.TabIndex = 9;
            this.titleFullNameButton.Text = "Show Title then Full Name";
            this.titleFullNameButton.UseVisualStyleBackColor = true;
            this.titleFullNameButton.Click += new System.EventHandler(this.TitleFullNameButton_Click);
            // 
            // fullNameButton
            // 
            this.fullNameButton.Location = new System.Drawing.Point(103, 166);
            this.fullNameButton.Name = "fullNameButton";
            this.fullNameButton.Size = new System.Drawing.Size(78, 52);
            this.fullNameButton.TabIndex = 10;
            this.fullNameButton.Text = "Show Full Name";
            this.fullNameButton.UseVisualStyleBackColor = true;
            this.fullNameButton.Click += new System.EventHandler(this.FullNameButton_Click);
            // 
            // firstLastNameButton
            // 
            this.firstLastNameButton.Location = new System.Drawing.Point(187, 166);
            this.firstLastNameButton.Name = "firstLastNameButton";
            this.firstLastNameButton.Size = new System.Drawing.Size(82, 52);
            this.firstLastNameButton.TabIndex = 11;
            this.firstLastNameButton.Text = "Show First and Last Name";
            this.firstLastNameButton.UseVisualStyleBackColor = true;
            this.firstLastNameButton.Click += new System.EventHandler(this.FirstLastNameButton_Click);
            // 
            // lastNameTitleButton
            // 
            this.lastNameTitleButton.Location = new System.Drawing.Point(12, 225);
            this.lastNameTitleButton.Name = "lastNameTitleButton";
            this.lastNameTitleButton.Size = new System.Drawing.Size(84, 51);
            this.lastNameTitleButton.TabIndex = 12;
            this.lastNameTitleButton.Text = "Show Last, First Middle, then Title";
            this.lastNameTitleButton.UseVisualStyleBackColor = true;
            this.lastNameTitleButton.Click += new System.EventHandler(this.LastNameTitleButton_Click);
            // 
            // lastFirstMiddleNameButton
            // 
            this.lastFirstMiddleNameButton.Location = new System.Drawing.Point(103, 225);
            this.lastFirstMiddleNameButton.Name = "lastFirstMiddleNameButton";
            this.lastFirstMiddleNameButton.Size = new System.Drawing.Size(78, 51);
            this.lastFirstMiddleNameButton.TabIndex = 13;
            this.lastFirstMiddleNameButton.Text = "Show Last, First then Middle Name";
            this.lastFirstMiddleNameButton.UseVisualStyleBackColor = true;
            this.lastFirstMiddleNameButton.Click += new System.EventHandler(this.LastFirstMiddleNameButton_Click);
            // 
            // lastFirstNameButton
            // 
            this.lastFirstNameButton.Location = new System.Drawing.Point(188, 225);
            this.lastFirstNameButton.Name = "lastFirstNameButton";
            this.lastFirstNameButton.Size = new System.Drawing.Size(81, 51);
            this.lastFirstNameButton.TabIndex = 14;
            this.lastFirstNameButton.Text = "Show Last, First Name";
            this.lastFirstNameButton.UseVisualStyleBackColor = true;
            this.lastFirstNameButton.Click += new System.EventHandler(this.LastFirstNameButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 282);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(122, 51);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(141, 282);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 51);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 348);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.lastFirstNameButton);
            this.Controls.Add(this.lastFirstMiddleNameButton);
            this.Controls.Add(this.lastNameTitleButton);
            this.Controls.Add(this.firstLastNameButton);
            this.Controls.Add(this.fullNameButton);
            this.Controls.Add(this.titleFullNameButton);
            this.Controls.Add(this.nameOutputLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Name Formatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label nameOutputLabel;
        private System.Windows.Forms.Button titleFullNameButton;
        private System.Windows.Forms.Button fullNameButton;
        private System.Windows.Forms.Button firstLastNameButton;
        private System.Windows.Forms.Button lastNameTitleButton;
        private System.Windows.Forms.Button lastFirstMiddleNameButton;
        private System.Windows.Forms.Button lastFirstNameButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

