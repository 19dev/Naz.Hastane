using System;
using System.Collections.Generic;
using System.Text;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;

namespace Naz.Mernis.Utilities.WCF
{
    public class KPSSecurityTokenProvider: SecurityTokenProvider
    {
        #region Fields

        private KPSSecurityToken token;

        #endregion

        #region Constructors

        public KPSSecurityTokenProvider(string username, string password)
        {
            this.token = new KPSSecurityToken(username, password);
        }

        #endregion

        #region Methods

        protected override SecurityToken GetTokenCore(TimeSpan timeout)
        {
            return token;
        }

        #endregion

    }
}
