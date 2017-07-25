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
            /*OrderCollection oc = new OrderCollection();
            for (int i = 0; i <= 2; i++)
            {
                Order o1 = new Order();
                o1.Email = "5ktg4qglw5598s3@marketplace.amazon.com";
                o1.OrderId = "103-7133341-8905855";
                o1.Item.ASIN = "B071K61DCV";
                o1.Name = "xiegeyang";
                o1.Item.Title = "T-Tek Product Cube Relieves Stress And Anxiety for Children and Adults Anxiety Attention Toy";
                Order o2 = new Order();
                o2.Email = "36z6hknvyxppdz7@marketplace.amazon.com";
                o2.OrderId = "114-7759912-3893010";
                o2.Item.ASIN = "B0746B61V6";
                o2.Name = "fangkaiyun";
                o2.Item.Title = "T-Tek Product Cube Relieves Stress And Anxiety for Children and Adults Anxiety Attention Toy";
                oc.Add(o1);
                oc.Add(o2);
            }*/

            EmailService.SendEmailByOrderCollection(_serviceCliamDefinition, _orderCollection, xmlTextBox);
        }

        private void emailContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailContextView emailContextView = new EmailContextView(_serviceCliamDefinition);
            emailContextView.ShowDialog();
        }


    }
}
