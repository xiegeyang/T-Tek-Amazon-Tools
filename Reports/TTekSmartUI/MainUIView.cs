using System;
using System.Windows.Forms;
using DataExchangeService;
using MarketplaceWebServiceOrders;

namespace TTekSmartUI
{
    public partial class MainUIView : Form
    {
        private ServiceCliamDefinition _serviceCliamDefinition;
        DateTime _createdAfterDateTime;
        DateTime _createdBeforeDateTime;
        private OrderCollection _orderCollection;



        public MainUIView(ServiceCliamDefinition serviceCliamDefinition)
        {
            this._serviceCliamDefinition = serviceCliamDefinition;
            InitializeComponent();
        }


        private void LogInToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            LogInView logInView = new LogInView(_serviceCliamDefinition);
            logInView.ShowDialog();
        }

        private void createdAfterDateTimePicker_ValueChanged(object sender, System.EventArgs e)
        {
            _createdAfterDateTime = createdAfterDateTimePicker.Value;
        }

        private void createdBeforeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _createdBeforeDateTime = createdBeforeDateTimePicker.Value;
        }

        private void getOrdersListButton_Click(object sender, System.EventArgs e)
        {
            _orderCollection = MarketplaceWebServiceOrdersDataAccess.InvokeListOrdersDetailByDateTime(_serviceCliamDefinition, _createdAfterDateTime, _createdBeforeDateTime);

            foreach (Order order in _orderCollection)
            {
                xmlTextBox.Text += "   \n" + order.OrderId + "  " + order.Email + "   " + order.Item.ASIN + "   " + order.Item.Title + "   "
                    + order.Name;
            }
            sendEmailsButton.Enabled = true;
            MessageBox.Show("OK!");
        }

        private void sendEmailsButton_Click(object sender, EventArgs e)
        {
            EmailService.SendEmailByOrderCollection(_orderCollection);
        }

        private void emailContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailContextView emailContextView = new EmailContextView(_serviceCliamDefinition);
            emailContextView.ShowDialog();
        }


    }
}
