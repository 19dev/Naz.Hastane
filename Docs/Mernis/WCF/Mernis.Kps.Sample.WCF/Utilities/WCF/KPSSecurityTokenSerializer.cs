using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel.Security;
using System.Xml;
using System.IdentityModel.Tokens;
using System.IdentityModel.Selectors;
using System.Security.Cryptography;

namespace Mernis.Kps.Sample.WCF.Utilities.WCF
{
    public class KPSSecurityTokenSerializer: WSSecurityTokenSerializer
    {

        public static class Constants
        {
            public const string WSSENamespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd";
            public const string WSSENamespacePrefix = "wsse";
            public const string WSSESecurityElementName = "Security";
            public const string UsernameTokenElementName = "UsernameToken";
            public const string UsernameElementName = "Username";
            public const string PasswordElementName = "Password";
            public const string PasswordTypeAttributeName = "Type";
            public const string PasswordTypeAttributeValue = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordDigest";
            public const string NonceElementName = "Nonce";
            public const string CreatedElementName = "Created";

            public const string SoapEnvelopeNamespace = "http://www.w3.org/2003/05/soap-envelope";
            public const string SoapEnvelopeNamespacePrefix = "soapenv";
            public const string MustUnderstandAttributeName = "mustUnderstand";

            public const string WSUNamespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd";
            public const string WSUNamespacePrefix = "wsu";
            public const string IdAttributeName = "Id";
        }

        #region Constructors

        public KPSSecurityTokenSerializer(SecurityVersion version)
            : base(version)
        {

        }

        #endregion

        #region Methods

        protected override bool CanReadTokenCore(XmlReader reader)
        {
            XmlDictionaryReader localReader = XmlDictionaryReader.CreateDictionaryReader(reader);

            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }

            return base.CanReadTokenCore(reader);
        }

        protected override SecurityToken ReadTokenCore(XmlReader reader, SecurityTokenResolver tokenResolver)
        {
            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }

            return WSSecurityTokenSerializer.DefaultInstance.ReadToken(reader, tokenResolver);
        }

        protected override bool CanWriteTokenCore(SecurityToken token)
        {
            if (token is KPSSecurityToken)
            {
                return true;
            }
            else
            {
                return base.CanWriteTokenCore(token);
            }
        }

        protected override void WriteTokenCore(XmlWriter writer, SecurityToken token)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }

            if (token == null)
            {
                throw new ArgumentNullException("token");
            }

            KPSSecurityToken kst = token as KPSSecurityToken;
            if (kst != null)
            {
               #region Username Token

                DateTime created = DateTime.Now.ToUniversalTime();
                byte[] nonce = new byte[16]; RandomNumberGenerator.Create().GetBytes(nonce);
                byte[] passwordHash = ComputePasswordDigest(nonce, created, kst.Password);

                writer.WriteStartElement(Constants.WSSENamespacePrefix, Constants.UsernameTokenElementName, Constants.WSSENamespace);
                writer.WriteAttributeString(Constants.WSUNamespacePrefix, Constants.IdAttributeName, Constants.WSUNamespace, Guid.NewGuid().ToString());

                writer.WriteElementString(Constants.WSSENamespacePrefix, Constants.UsernameElementName, Constants.WSSENamespace, kst.Username);
                writer.WriteStartElement(Constants.WSSENamespacePrefix, Constants.PasswordElementName, Constants.WSSENamespace);
                writer.WriteAttributeString(Constants.PasswordTypeAttributeName, Constants.PasswordTypeAttributeValue);
                writer.WriteString(Convert.ToBase64String(passwordHash));
                writer.WriteEndElement();
                writer.WriteElementString(Constants.WSSENamespacePrefix, Constants.NonceElementName, Constants.WSSENamespace, Convert.ToBase64String(nonce));
                writer.WriteElementString(Constants.CreatedElementName, Constants.WSUNamespace, XmlConvert.ToString(created, "yyyy-MM-ddTHH:mm:ssZ"));

                writer.WriteEndElement();

                #endregion
            }
            else
            {
                base.WriteTokenCore(writer, token);
            }
        }

        #endregion

        private static byte[] ComputePasswordDigest(byte[] nonce, DateTime created, string secret)
        {
            if ((nonce == null) || (nonce.Length == 0))
            {
                throw new ArgumentNullException("nonce");
            }
            if (secret == null)
            {
                throw new ArgumentNullException("secret");
            }
            byte[] bytes = Encoding.UTF8.GetBytes(XmlConvert.ToString(created.ToUniversalTime(), "yyyy-MM-ddTHH:mm:ssZ"));
            byte[] sourceArray = Encoding.UTF8.GetBytes(secret);
            byte[] destinationArray = new byte[(nonce.Length + bytes.Length) + sourceArray.Length];
            Array.Copy(nonce, destinationArray, nonce.Length);
            Array.Copy(bytes, 0, destinationArray, nonce.Length, bytes.Length);
            Array.Copy(sourceArray, 0, destinationArray, nonce.Length + bytes.Length, sourceArray.Length);
            return SHA1.Create().ComputeHash(destinationArray);
        }

 

 


    }
}
