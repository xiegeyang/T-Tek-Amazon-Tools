using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Xml;
using DataExchangeService;
using MarketplaceWebServiceOrders;
using MarketplaceWebServiceOrders.Model;

namespace TTekSmartUI
{
    public partial class MainUIView : Form
    {
        private ServiceCliamDefinition _serviceCliamDefinition;
        DateTime _createdAfterDateTime;
        DateTime _createdBeforeDateTime;
        private List<string> _emailCollection;



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
            IMWSResponse listOrdersResponse = null;
            listOrdersResponse = MarketplaceWebServiceOrdersEntity.InvokeListOrdersByDateTime(_serviceCliamDefinition, _createdAfterDateTime, _createdBeforeDateTime);
            ResponseHeaderMetadata rhmd = listOrdersResponse.ResponseHeaderMetadata;
            string responseXml = listOrdersResponse.ToXML();
            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(responseXml);
            XmlNodeList emailList = xDoc.GetElementsByTagName("BuyerEmail");

            if (_emailCollection == null)
            {
                _emailCollection = new List<string>();
            }
            foreach (XmlNode email in emailList)
            {
                xmlTextBox.Text += "\n";
                xmlTextBox.Text += email.InnerText;
                xmlTextBox.Text += "\n    ";
                _emailCollection.Add(email.InnerText);
            }
            MessageBox.Show("OK!");
        }

        private void sendEmailsButton_Click(object sender, EventArgs e)
        {
            MailAddress fromAddress = new MailAddress("xiegeyang@t-tekproduct.com", "T-Tek Product Team");
            MailAddress toAddress = new MailAddress("5ktg4qglw5598s3@marketplace.amazon.com", "Customer");
            string fromPassword = "X199241gy";
            string subject = "Need Review";
            string body = "Need Your Review";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }

        }


    }
}
