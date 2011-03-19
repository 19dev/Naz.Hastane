using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel.Description;
using System.ServiceModel;
using System.IdentityModel.Selectors;
using System.ServiceModel.Security;

namespace Mernis.Kps.Sample.WCF.Utilities.WCF
{
    public class KPSSecurityTokenManager: ClientCredentialsSecurityTokenManager
    {
        #region Fields

        private KPSClientCredentials creds;

        #endregion

        #region Constructors

        public KPSSecurityTokenManager(KPSClientCredentials creds)
            : base(creds)
        {
            if (creds == null)
            {
                throw new ArgumentNullException("creds");
            }

            this.creds = creds;
        }

        #endregion

        #region Methods

        public override SecurityTokenSerializer CreateSecurityTokenSerializer(SecurityTokenVersion version)
        {
            return new KPSSecurityTokenSerializer(SecurityVersion.WSSecurity11);
        }

        public override SecurityTokenProvider CreateSecurityTokenProvider(SecurityTokenRequirement tokenRequirement)
        {
            if (tokenRequirement == null)
                throw new ArgumentNullException("tokenRequirement");

            if (tokenRequirement.TokenType == KPSSecurityTokenParameters.TokenType)
            {
                return new KPSSecurityTokenProvider(creds.Username, creds.Password);
            }
            else
            {
                return base.CreateSecurityTokenProvider(tokenRequirement);
            }
        }

        #endregion

    }
}
