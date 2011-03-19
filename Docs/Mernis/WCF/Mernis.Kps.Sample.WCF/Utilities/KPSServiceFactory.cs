using System;
using System.Collections.Generic;
using System.Text;
using Mernis.Kps.Sample.WCF.Service;
using System.ServiceModel.Channels;
using Mernis.Kps.Sample.WCF.Utilities.WCF;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Net;

namespace Mernis.Kps.Sample.WCF.Utilities
{
    public static class KPSServiceFactory
    {

        public static KPSSoap Create()
        {
            KPSSoapClient service = new KPSSoapClient(CreateBinding(), new EndpointAddress(KPSConfiguration.Instance.EndPoint));

            KPSClientCredentials creds = new KPSClientCredentials();
            creds.Username = KPSConfiguration.Instance.Username;
            creds.Password = KPSConfiguration.Instance.Password;

            service.ChannelFactory.Endpoint.Behaviors.Remove<ClientCredentials>();
            service.ChannelFactory.Endpoint.Behaviors.Add(creds);

            return service;
        }

        private static Binding CreateBinding()
        {
            HttpsTransportBindingElement httpTransport = new HttpsTransportBindingElement();
            httpTransport.ManualAddressing = false;
            httpTransport.MaxBufferPoolSize = 524288;
            httpTransport.MaxReceivedMessageSize = 65536;
            httpTransport.AllowCookies = false;
            httpTransport.AuthenticationScheme = AuthenticationSchemes.Anonymous;
            httpTransport.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
            httpTransport.KeepAliveEnabled = true;
            httpTransport.MaxBufferSize = 65536;
            httpTransport.TransferMode = TransferMode.Buffered;
            httpTransport.RequireClientCertificate = false;

            TextMessageEncodingBindingElement encoding = new TextMessageEncodingBindingElement();
            encoding.MessageVersion = MessageVersion.Soap12;
            encoding.MaxReadPoolSize = 64;
            encoding.MaxWritePoolSize = 16;
            encoding.WriteEncoding = Encoding.UTF8;

            TransportSecurityBindingElement transportSecurity = new TransportSecurityBindingElement();
            transportSecurity.EndpointSupportingTokenParameters.SignedEncrypted.Add(new KPSSecurityTokenParameters());
            transportSecurity.IncludeTimestamp = true;

            return new CustomBinding(transportSecurity, encoding, httpTransport);
        }

    }
}
