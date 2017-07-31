using System;
using System.Windows.Forms;
using DataExchangeService;

namespace TTekSmartUI
{
    public partial class SetLastInvokeDateTimeView : Form
    {
        private ServiceCliamDefinition _serviceCliamDefinition;
        public SetLastInvokeDateTimeView(ServiceCliamDefinition serviceCliamDefinition)
        {
            this._serviceCliamDefinition = serviceCliamDefinition;
            InitializeComponent();
        }

        private void setDateTimeButton_Click(object sender, EventArgs e)
        {
            _serviceCliamDefinition.LastInvokeDateTime = dateTimePicker.Value;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
