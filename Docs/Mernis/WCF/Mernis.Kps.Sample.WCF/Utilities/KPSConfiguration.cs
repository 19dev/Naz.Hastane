using System;
using System.Collections.Generic;
using System.Text;

namespace Mernis.Kps.Sample.WCF.Utilities
{
    public class KPSConfiguration
    {

        public static KPSConfiguration Instance = new KPSConfiguration();

        #region Fields

        private string endPoint;
        private string username;
        private string password;

        #endregion

        #region Constructors

        private KPSConfiguration()
        {
            endPoint = "https://kps.nvi.gov.tr/Mernis.KPS.Web.SI/KPS.asmx";
        }

        #endregion

        #region Properties

        public string EndPoint
        {
            get { return endPoint; }
            set { endPoint = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        #endregion

    }
}
