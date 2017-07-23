using System.Windows.Forms;
using DataExchangeService;

namespace TTekSmartUI
{
    public partial class LogInView : Form
    {
        private ServiceCliamDefinition _serviceCliaimDefinition;
        public LogInView(ServiceCliamDefinition serviceCliamDefinition)
        {
            this._serviceCliaimDefinition = serviceCliamDefinition;
            InitializeComponent();
        }

        private void logInButton_Click(object sender, System.EventArgs e)
        {
            _serviceCliaimDefinition.SellerId = sellerIdTextBox.Text;
            _serviceCliaimDefinition.AuthToken = authTokenTextBox.Text;
            this.Close();
        }
    }
}
