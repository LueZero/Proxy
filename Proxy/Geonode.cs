using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace Proxy
{
    public class Geonode : Proxy
    {
        private const string Username = "geonode_tGsXR6vkQ8-autoReplace-True";
        private const string Password = "b98a3a57-5902-4275-8826-f5da2e01e381";

        public Geonode(string proxyHost = "http://premium-residential.geonode.com", int proxyPort = 9000)
        {
            ProxyHost = proxyHost;
            ProxyPort = proxyPort;
        }

        public override async Task<string> GetPorxyRequest(Dictionary<string, string> headers = null)
        {
            using var httpClient = new HttpClient(new HttpClientHandler
            {
                Proxy = new WebProxy(ProxyHost, ProxyPort),
                Credentials = new NetworkCredential(Username, Password)
            });

            var responseMessage = await httpClient.GetAsync(TargetUrl);
            var contentString = await responseMessage.Content.ReadAsStringAsync();

            return contentString;
        }
    }
}
