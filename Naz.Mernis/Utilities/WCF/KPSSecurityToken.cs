using System;
using System.Collections.Generic;
using System.Text;
using System.IdentityModel.Tokens;
using System.Collections.ObjectModel;

namespace Naz.Mernis.Utilities.WCF
{
    public sealed class KPSSecurityToken: SecurityToken
    {
        #region Fields

        private string id;
        private string username;
        private string password;
        private DateTime validFrom;
        private DateTime validTo;
        private ReadOnlyCollection<SecurityKey> securityKeys;

        #endregion

        #region Constructors

        public KPSSecurityToken(string username, string password)
            : this(username, password, Guid.NewGuid().ToString())
        {

        }

        public KPSSecurityToken(string username, string password, string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("id");
            }

            if (username == null)
            {
                throw new ArgumentNullException("username");
            }

            if (password == null)
            {
                throw new ArgumentNullException("password");
            }

            this.id = id;
            this.username = username;
            this.password = password;
            this.validFrom = DateTime.MinValue;
            this.validTo = DateTime.MaxValue;
            this.securityKeys = new List<SecurityKey>().AsReadOnly();
        }

        #endregion

        #region Properties

        public override string Id
        {
            get { return id; }
        }

        public override ReadOnlyCollection<SecurityKey> SecurityKeys
        {
            get { return securityKeys; }
        }

        public override DateTime ValidFrom
        {
            get { return validFrom; }
        }

        public override DateTime ValidTo
        {
            get { return validTo; }
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
