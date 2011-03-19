using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel.Security.Tokens;
using System.IdentityModel.Tokens;
using System.IdentityModel.Selectors;

namespace Naz.Mernis.Utilities.WCF
{
    public class KPSSecurityTokenParameters : SecurityTokenParameters
    {
        #region Constants

        public const string TokenType = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd";

        #endregion

        #region Fields

        #endregion

        #region Constructors

        public KPSSecurityTokenParameters()
        {

        }

        public KPSSecurityTokenParameters(KPSSecurityTokenParameters other)
            : base(other)
        {

        }

        #endregion

        #region Properties

        protected override bool HasAsymmetricKey
        {
            get { return false; }
        }

        protected override bool SupportsClientAuthentication
        {
            get { return true; }
        }

        protected override bool SupportsClientWindowsIdentity
        {
            get { return false; }
        }

        protected override bool SupportsServerAuthentication
        {
            get { return false; }
        }

        #endregion

        #region Methods

        protected override SecurityTokenParameters CloneCore()
        {
            return new KPSSecurityTokenParameters(this);
        }

        protected override SecurityKeyIdentifierClause CreateKeyIdentifierClause(SecurityToken token, SecurityTokenReferenceStyle referenceStyle)
        {
            if (referenceStyle == SecurityTokenReferenceStyle.Internal)
            {
                return token.CreateKeyIdentifierClause<LocalIdKeyIdentifierClause>();
            }
            else
            {
                throw new NotSupportedException("External references are not supported for username password tokens");
            }
        }

        protected override void InitializeSecurityTokenRequirement(SecurityTokenRequirement requirement)
        {
            requirement.TokenType = TokenType;
        }

        #endregion

    }
}
