namespace TTekSmartUI
{
    partial class SetLastInvokeDateTimeView
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.setDateTimeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.messageLabel.Location = new System.Drawing.Point(12, 34);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(255, 50);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Please Set The Start Date and Time of Invoking";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(16, 97);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // setDateTimeButton
            // 
            this.setDateTimeButton.Location = new System.Drawing.Point(16, 154);
            this.setDateTimeButton.Name = "setDateTimeButton";
            this.setDateTimeButton.Size = new System.Drawing.Size(211, 23);
            this.setDateTimeButton.TabIndex = 2;
            this.setDateTimeButton.Text = "Set";
            this.setDateTimeButton.UseVisualStyleBackColor = true;
            this.setDateTimeButton.Click += new System.EventHandler(this.setDateTimeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(16, 210);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(211, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SetLastInvokeDateTimeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 293);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.setDateTimeButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.messageLabel);
            this.Name = "SetLastInvokeDateTimeView";
            this.Text = "SetLastInvokeDateTimeView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button setDateTimeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}