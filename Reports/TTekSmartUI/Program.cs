using System;
using System.Windows.Forms;
using DataExchangeService;

namespace TTekSmartUI
{
    static class Program
    {
        // TODO: Set the below configuration variables before attempting to run
        private static string _sellerId = "A380610PV1XE6A";
        private static string _MWSAuthToken = "amzn.mws.76aeb40f-2625-ef1b-7942-f41976b59227";

        private static string _developerId = "5743-5830-5903";

        // Developer AWS access key
        private static string _accessKey = "AKIAIKYYTE7TYRWSAIEA";

        // Developer AWS secret key
        private static string _secretKey = "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";

        private static string _marketplaceId = "ATVPDKIKX0DER";

        // The client application name
        private static string _appName = "T-Tek Tool";

        // The client application version
        private static string _appVersion = "1.0";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServiceCliamDefinition serviceCliamDefinition = new ServiceCliamDefinition(_sellerId, _MWSAuthToken, _accessKey, _secretKey, _marketplaceId);
            serviceCliamDefinition.GetFromXml();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainUIView(serviceCliamDefinition));
        }
    }
}
