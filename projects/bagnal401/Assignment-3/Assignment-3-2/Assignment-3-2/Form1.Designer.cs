namespace Assignment_3_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classCTextBox = new System.Windows.Forms.TextBox();
            this.classBTextBox = new System.Windows.Forms.TextBox();
            this.classATextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.classCLabel = new System.Windows.Forms.Label();
            this.classBLabel = new System.Windows.Forms.Label();
            this.classALabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calculateRevenueButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.totalRevenueLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classCTextBox);
            this.groupBox1.Controls.Add(this.classBTextBox);
            this.groupBox1.Controls.Add(this.classATextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // classCTextBox
            // 
            this.classCTextBox.Location = new System.Drawing.Point(62, 133);
            this.classCTextBox.Name = "classCTextBox";
            this.classCTextBox.Size = new System.Drawing.Size(100, 20);
            this.classCTextBox.TabIndex = 6;
            // 
            // classBTextBox
            // 
            this.classBTextBox.Location = new System.Drawing.Point(62, 95);
            this.classBTextBox.Name = "classBTextBox";
            this.classBTextBox.Size = new System.Drawing.Size(100, 20);
            this.classBTextBox.TabIndex = 5;
            // 
            // classATextBox
            // 
            this.classATextBox.Location = new System.Drawing.Point(62, 53);
            this.classATextBox.Name = "classATextBox";
            this.classATextBox.Size = new System.Drawing.Size(100, 20);
            this.classATextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class A:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalRevenueLabel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.classCLabel);
            this.groupBox2.Controls.Add(this.classBLabel);
            this.groupBox2.Controls.Add(this.classALabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(241, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            // 
            // classCLabel
            // 
            this.classCLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classCLabel.Location = new System.Drawing.Point(59, 95);
            this.classCLabel.Name = "classCLabel";
            this.classCLabel.Size = new System.Drawing.Size(135, 23);
            this.classCLabel.TabIndex = 5;
            this.classCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classBLabel
            // 
            this.classBLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classBLabel.Location = new System.Drawing.Point(58, 55);
            this.classBLabel.Name = "classBLabel";
            this.classBLabel.Size = new System.Drawing.Size(135, 23);
            this.classBLabel.TabIndex = 4;
            this.classBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classALabel
            // 
            this.classALabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classALabel.Location = new System.Drawing.Point(59, 19);
            this.classALabel.Name = "classALabel";
            this.classALabel.Size = new System.Drawing.Size(134, 23);
            this.classALabel.TabIndex = 3;
            this.classALabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Class C:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Class B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Class A:";
            // 
            // calculateRevenueButton
            // 
            this.calculateRevenueButton.Location = new System.Drawing.Point(76, 204);
            this.calculateRevenueButton.Name = "calculateRevenueButton";
            this.calculateRevenueButton.Size = new System.Drawing.Size(75, 38);
            this.calculateRevenueButton.TabIndex = 2;
            this.calculateRevenueButton.Text = "Calculate Revenue";
            this.calculateRevenueButton.UseVisualStyleBackColor = true;
            this.calculateRevenueButton.Click += new System.EventHandler(this.CalculateRevenueButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(189, 204);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 38);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(299, 204);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 38);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total";
            // 
            // totalRevenueLabel
            // 
            this.totalRevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalRevenueLabel.Location = new System.Drawing.Point(58, 130);
            this.totalRevenueLabel.Name = "totalRevenueLabel";
            this.totalRevenueLabel.Size = new System.Drawing.Size(135, 24);
            this.totalRevenueLabel.TabIndex = 7;
            this.totalRevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 254);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateRevenueButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox classCTextBox;
        private System.Windows.Forms.TextBox classBTextBox;
        private System.Windows.Forms.TextBox classATextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label classCLabel;
        private System.Windows.Forms.Label classBLabel;
        private System.Windows.Forms.Label classALabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calculateRevenueButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalRevenueLabel;
        private System.Windows.Forms.Label label8;
    }
}

