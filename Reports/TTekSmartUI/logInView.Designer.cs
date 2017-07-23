namespace TTekSmartUI
{
    partial class LogInView
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
            this.sellerIdTextBox = new System.Windows.Forms.TextBox();
            this.authTokenTextBox = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.sellerIdLabel = new System.Windows.Forms.Label();
            this.authTokenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sellerIdTextBox
            // 
            this.sellerIdTextBox.Location = new System.Drawing.Point(127, 102);
            this.sellerIdTextBox.Name = "sellerIdTextBox";
            this.sellerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.sellerIdTextBox.TabIndex = 0;
            // 
            // authTokenTextBox
            // 
            this.authTokenTextBox.Location = new System.Drawing.Point(127, 147);
            this.authTokenTextBox.Name = "authTokenTextBox";
            this.authTokenTextBox.Size = new System.Drawing.Size(100, 20);
            this.authTokenTextBox.TabIndex = 1;
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(127, 196);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(100, 23);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // sellerIdLabel
            // 
            this.sellerIdLabel.AutoSize = true;
            this.sellerIdLabel.Location = new System.Drawing.Point(28, 105);
            this.sellerIdLabel.Name = "sellerIdLabel";
            this.sellerIdLabel.Size = new System.Drawing.Size(45, 13);
            this.sellerIdLabel.TabIndex = 3;
            this.sellerIdLabel.Text = "Seller Id";
            // 
            // authTokenLabel
            // 
            this.authTokenLabel.AutoSize = true;
            this.authTokenLabel.Location = new System.Drawing.Point(28, 154);
            this.authTokenLabel.Name = "authTokenLabel";
            this.authTokenLabel.Size = new System.Drawing.Size(93, 13);
            this.authTokenLabel.TabIndex = 4;
            this.authTokenLabel.Text = "MWS Auth Token";
            // 
            // LogInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 288);
            this.Controls.Add(this.authTokenLabel);
            this.Controls.Add(this.sellerIdLabel);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.authTokenTextBox);
            this.Controls.Add(this.sellerIdTextBox);
            this.Name = "LogInView";
            this.Text = "logInView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sellerIdTextBox;
        private System.Windows.Forms.TextBox authTokenTextBox;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label sellerIdLabel;
        private System.Windows.Forms.Label authTokenLabel;
    }
}