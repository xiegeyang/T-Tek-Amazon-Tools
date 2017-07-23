namespace TTekSmartUI
{
    partial class MainUIView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getOrdersListButton = new System.Windows.Forms.Button();
            this.createdAfterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.xmlTextBox = new System.Windows.Forms.TextBox();
            this.sendEmailsButton = new System.Windows.Forms.Button();
            this.createdBeforeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1245, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.LogInToolStripMenuItem_Click);
            // 
            // getOrdersListButton
            // 
            this.getOrdersListButton.Location = new System.Drawing.Point(38, 145);
            this.getOrdersListButton.Name = "getOrdersListButton";
            this.getOrdersListButton.Size = new System.Drawing.Size(75, 23);
            this.getOrdersListButton.TabIndex = 1;
            this.getOrdersListButton.Text = "Get Orders";
            this.getOrdersListButton.UseVisualStyleBackColor = true;
            this.getOrdersListButton.Click += new System.EventHandler(this.getOrdersListButton_Click);
            // 
            // createdAfterDateTimePicker
            // 
            this.createdAfterDateTimePicker.Location = new System.Drawing.Point(38, 60);
            this.createdAfterDateTimePicker.Name = "createdAfterDateTimePicker";
            this.createdAfterDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.createdAfterDateTimePicker.TabIndex = 3;
            this.createdAfterDateTimePicker.ValueChanged += new System.EventHandler(this.createdAfterDateTimePicker_ValueChanged);
            // 
            // xmlTextBox
            // 
            this.xmlTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.xmlTextBox.Location = new System.Drawing.Point(763, 24);
            this.xmlTextBox.Multiline = true;
            this.xmlTextBox.Name = "xmlTextBox";
            this.xmlTextBox.Size = new System.Drawing.Size(482, 569);
            this.xmlTextBox.TabIndex = 4;
            // 
            // sendEmailsButton
            // 
            this.sendEmailsButton.Location = new System.Drawing.Point(163, 145);
            this.sendEmailsButton.Name = "sendEmailsButton";
            this.sendEmailsButton.Size = new System.Drawing.Size(75, 23);
            this.sendEmailsButton.TabIndex = 5;
            this.sendEmailsButton.Text = "Send Email";
            this.sendEmailsButton.UseVisualStyleBackColor = true;
            this.sendEmailsButton.Click += new System.EventHandler(this.sendEmailsButton_Click);
            // 
            // createdBeforeDateTimePicker
            // 
            this.createdBeforeDateTimePicker.Location = new System.Drawing.Point(38, 104);
            this.createdBeforeDateTimePicker.Name = "createdBeforeDateTimePicker";
            this.createdBeforeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.createdBeforeDateTimePicker.TabIndex = 6;
            this.createdBeforeDateTimePicker.ValueChanged += new System.EventHandler(this.createdBeforeDateTimePicker_ValueChanged);
            // 
            // MainUIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 593);
            this.Controls.Add(this.createdBeforeDateTimePicker);
            this.Controls.Add(this.sendEmailsButton);
            this.Controls.Add(this.xmlTextBox);
            this.Controls.Add(this.createdAfterDateTimePicker);
            this.Controls.Add(this.getOrdersListButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainUIView";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.Button getOrdersListButton;
        private System.Windows.Forms.DateTimePicker createdAfterDateTimePicker;
        private System.Windows.Forms.TextBox xmlTextBox;
        private System.Windows.Forms.Button sendEmailsButton;
        private System.Windows.Forms.DateTimePicker createdBeforeDateTimePicker;
    }
}

