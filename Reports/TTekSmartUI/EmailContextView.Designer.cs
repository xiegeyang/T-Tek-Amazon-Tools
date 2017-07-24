namespace TTekSmartUI
{
    partial class EmailContextView
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
            this.emailContaxtTextBox = new System.Windows.Forms.TextBox();
            this.saveContextButton = new System.Windows.Forms.Button();
            this.cancelContextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailContaxtTextBox
            // 
            this.emailContaxtTextBox.Location = new System.Drawing.Point(-3, 52);
            this.emailContaxtTextBox.Multiline = true;
            this.emailContaxtTextBox.Name = "emailContaxtTextBox";
            this.emailContaxtTextBox.Size = new System.Drawing.Size(929, 493);
            this.emailContaxtTextBox.TabIndex = 0;
            // 
            // saveContextButton
            // 
            this.saveContextButton.Location = new System.Drawing.Point(659, 584);
            this.saveContextButton.Name = "saveContextButton";
            this.saveContextButton.Size = new System.Drawing.Size(75, 23);
            this.saveContextButton.TabIndex = 1;
            this.saveContextButton.Text = "Save";
            this.saveContextButton.UseVisualStyleBackColor = true;
            this.saveContextButton.Click += new System.EventHandler(this.saveContextButton_Click);
            // 
            // cancelContextButton
            // 
            this.cancelContextButton.Location = new System.Drawing.Point(793, 584);
            this.cancelContextButton.Name = "cancelContextButton";
            this.cancelContextButton.Size = new System.Drawing.Size(75, 23);
            this.cancelContextButton.TabIndex = 2;
            this.cancelContextButton.Text = "Cancel";
            this.cancelContextButton.UseVisualStyleBackColor = true;
            // 
            // EmailContextView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 625);
            this.Controls.Add(this.cancelContextButton);
            this.Controls.Add(this.saveContextButton);
            this.Controls.Add(this.emailContaxtTextBox);
            this.Name = "EmailContextView";
            this.Text = "EmailContextView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailContaxtTextBox;
        private System.Windows.Forms.Button saveContextButton;
        private System.Windows.Forms.Button cancelContextButton;
    }
}