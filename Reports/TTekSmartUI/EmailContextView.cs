using System;
using System.Windows.Forms;
using DataExchangeService;

namespace TTekSmartUI
{
    public partial class EmailContextView : Form
    {

        private ServiceCliamDefinition _serviceCliamDefinition;
        public EmailContextView(ServiceCliamDefinition serviceCliamDefinition)
        {
            this._serviceCliamDefinition = serviceCliamDefinition;
            InitializeComponent();
        }

        private void saveContextButton_Click(object sender, EventArgs e)
        {

        }

        private void sendSampleButton_Click(object sender, EventArgs e)
        {
            if (toEmailAddressTextBox.Equals(String.Empty))
            {
                return;
            }

            EmailService.SendEmailByCustomizeEmail(_serviceCliamDefinition ,toEmailAddressTextBox.Text, subjectTextBox.Text, bodyTextBox.Text);
        }
    }
}
