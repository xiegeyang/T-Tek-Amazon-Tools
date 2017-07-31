using System.Windows.Forms;

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
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvokeOrdersListButton = new System.Windows.Forms.Button();
            this.createdAfterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.xmlTextBox = new System.Windows.Forms.TextBox();
            this.sendEmailsButton = new System.Windows.Forms.Button();
            this.createdBeforeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getOrdersButton = new System.Windows.Forms.Button();
            this.invokeOrdersByNextDateButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.editToolStripMenuItem});
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
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailContextToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // emailContextToolStripMenuItem
            // 
            this.emailContextToolStripMenuItem.Name = "emailContextToolStripMenuItem";
            this.emailContextToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.emailContextToolStripMenuItem.Text = "Email Context";
            this.emailContextToolStripMenuItem.Click += new System.EventHandler(this.emailContextToolStripMenuItem_Click);
            // 
            // InvokeOrdersListButton
            // 
            this.InvokeOrdersListButton.Location = new System.Drawing.Point(38, 145);
            this.InvokeOrdersListButton.Name = "InvokeOrdersListButton";
            this.InvokeOrdersListButton.Size = new System.Drawing.Size(200, 23);
            this.InvokeOrdersListButton.TabIndex = 1;
            this.InvokeOrdersListButton.Text = "Invoke Orders From MWS";
            this.InvokeOrdersListButton.UseVisualStyleBackColor = true;
            this.InvokeOrdersListButton.Click += new System.EventHandler(this.InvokeOrdersListButton_Click);
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
            this.xmlTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xmlTextBox.Location = new System.Drawing.Point(0, 500);
            this.xmlTextBox.Multiline = true;
            this.xmlTextBox.Name = "xmlTextBox";
            this.xmlTextBox.Size = new System.Drawing.Size(1245, 93);
            this.xmlTextBox.TabIndex = 4;
            // 
            // sendEmailsButton
            // 
            this.sendEmailsButton.Enabled = false;
            this.sendEmailsButton.Location = new System.Drawing.Point(38, 174);
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
            // ordersDataGridView
            // 
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.customerName,
            this.email,
            this.ASIN,
            this.itemTitle});
            this.ordersDataGridView.Location = new System.Drawing.Point(681, 27);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(564, 470);
            this.ordersDataGridView.TabIndex = 7;
            // 
            // orderId
            // 
            this.orderId.HeaderText = "Order Id";
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // ASIN
            // 
            this.ASIN.HeaderText = "ASIN";
            this.ASIN.Name = "ASIN";
            this.ASIN.ReadOnly = true;
            // 
            // itemTitle
            // 
            this.itemTitle.HeaderText = "Item Title";
            this.itemTitle.Name = "itemTitle";
            this.itemTitle.ReadOnly = true;
            // 
            // getOrdersButton
            // 
            this.getOrdersButton.Location = new System.Drawing.Point(38, 203);
            this.getOrdersButton.Name = "getOrdersButton";
            this.getOrdersButton.Size = new System.Drawing.Size(200, 23);
            this.getOrdersButton.TabIndex = 8;
            this.getOrdersButton.Text = "Get Orders From Database";
            this.getOrdersButton.UseVisualStyleBackColor = true;
            this.getOrdersButton.Click += new System.EventHandler(this.getOrdersButton_Click);
            // 
            // invokeOrdersByNextDateButton
            // 
            this.invokeOrdersByNextDateButton.Location = new System.Drawing.Point(38, 232);
            this.invokeOrdersByNextDateButton.Name = "invokeOrdersByNextDateButton";
            this.invokeOrdersByNextDateButton.Size = new System.Drawing.Size(200, 23);
            this.invokeOrdersByNextDateButton.TabIndex = 9;
            this.invokeOrdersByNextDateButton.Text = "Invoke Order By Next Date";
            this.invokeOrdersByNextDateButton.UseVisualStyleBackColor = true;
            this.invokeOrdersByNextDateButton.Click += new System.EventHandler(this.invokeOrdersByNextDateButton_Click);
            // 
            // MainUIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 593);
            this.Controls.Add(this.invokeOrdersByNextDateButton);
            this.Controls.Add(this.getOrdersButton);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.createdBeforeDateTimePicker);
            this.Controls.Add(this.sendEmailsButton);
            this.Controls.Add(this.xmlTextBox);
            this.Controls.Add(this.createdAfterDateTimePicker);
            this.Controls.Add(this.InvokeOrdersListButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainUIView";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUIView_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.Button InvokeOrdersListButton;
        private System.Windows.Forms.DateTimePicker createdAfterDateTimePicker;
        private System.Windows.Forms.TextBox xmlTextBox;
        private System.Windows.Forms.Button sendEmailsButton;
        private System.Windows.Forms.DateTimePicker createdBeforeDateTimePicker;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailContextToolStripMenuItem;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTitle;
        private System.Windows.Forms.Button getOrdersButton;
        private Button invokeOrdersByNextDateButton;
    }
}

