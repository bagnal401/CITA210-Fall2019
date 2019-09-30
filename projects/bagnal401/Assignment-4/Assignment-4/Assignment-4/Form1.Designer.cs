namespace Assignment_4
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
            this.romanNumeralTextBox = new System.Windows.Forms.TextBox();
            this.romanNumeralLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number between 1 and 10 and I\'ll convert it to a roman numeral:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // romanNumeralTextBox
            // 
            this.romanNumeralTextBox.Location = new System.Drawing.Point(264, 28);
            this.romanNumeralTextBox.Name = "romanNumeralTextBox";
            this.romanNumeralTextBox.Size = new System.Drawing.Size(100, 20);
            this.romanNumeralTextBox.TabIndex = 1;
            // 
            // romanNumeralLabel
            // 
            this.romanNumeralLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.romanNumeralLabel.Location = new System.Drawing.Point(64, 58);
            this.romanNumeralLabel.Name = "romanNumeralLabel";
            this.romanNumeralLabel.Size = new System.Drawing.Size(243, 33);
            this.romanNumeralLabel.TabIndex = 2;
            this.romanNumeralLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(27, 114);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 34);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(157, 114);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 34);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(293, 114);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 34);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 169);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.romanNumeralLabel);
            this.Controls.Add(this.romanNumeralTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox romanNumeralTextBox;
        private System.Windows.Forms.Label romanNumeralLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

