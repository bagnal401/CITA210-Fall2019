namespace Assignment_3
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
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.fahrenheitButton = new System.Windows.Forms.Button();
            this.celsiusButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number and I will convert it to Fahrenheit or Celsius";
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(99, 68);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(100, 20);
            this.temperatureTextBox.TabIndex = 1;
            // 
            // fahrenheitButton
            // 
            this.fahrenheitButton.Location = new System.Drawing.Point(43, 147);
            this.fahrenheitButton.Name = "fahrenheitButton";
            this.fahrenheitButton.Size = new System.Drawing.Size(105, 41);
            this.fahrenheitButton.TabIndex = 2;
            this.fahrenheitButton.Text = "Convert to Fahrenheit";
            this.fahrenheitButton.UseVisualStyleBackColor = true;
            this.fahrenheitButton.Click += new System.EventHandler(this.FahrenheitButton_Click);
            // 
            // celsiusButton
            // 
            this.celsiusButton.Location = new System.Drawing.Point(154, 147);
            this.celsiusButton.Name = "celsiusButton";
            this.celsiusButton.Size = new System.Drawing.Size(101, 41);
            this.celsiusButton.TabIndex = 3;
            this.celsiusButton.Text = "Convert to Celsius";
            this.celsiusButton.UseVisualStyleBackColor = true;
            this.celsiusButton.Click += new System.EventHandler(this.CelsiusButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(43, 195);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(105, 41);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(155, 195);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 41);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.temperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureLabel.Location = new System.Drawing.Point(43, 105);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(212, 27);
            this.temperatureLabel.TabIndex = 6;
            this.temperatureLabel.Text = "Answer will appear here!";
            this.temperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 257);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.celsiusButton);
            this.Controls.Add(this.fahrenheitButton);
            this.Controls.Add(this.temperatureTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.Button fahrenheitButton;
        private System.Windows.Forms.Button celsiusButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label temperatureLabel;
    }
}

