using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel.Description;
using System.IdentityModel.Selectors;
using System.Threading;

namespace Naz.Mernis.Utilities.WCF
{
    public class KPSClientCredentials: ClientCredentials
    {
        #region Fields

        private string username;
        private string password;

        #endregion

        #region Constructors

        public KPSClientCredentials()
            : base()
        {

        }

        public KPSClientCredentials(KPSClientCredentials other)
            : base(other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

            this.username = other.username;
            this.password = other.password;
        }

        #endregion

        #region Properties

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

        #region Methods

        protected override ClientCredentials CloneCore()
        {
            return new KPSClientCredentials(this);
        }

        public override SecurityTokenManager CreateSecurityTokenManager()
        {
            return new KPSSecurityTokenManager(this);
        }

        #endregion
    }
}
