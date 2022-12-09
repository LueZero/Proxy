using System;
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

        public Geonode()
        {
            MyProxyHost = "http://premium-residential.geonode.com";
            MyProxyPort = 9000;
        }

        public override async Task<string> GetPorxyRequest()
        {
            using var httpClient = new HttpClient(new HttpClientHandler
            {
                Proxy = new WebProxy(MyProxyHost, MyProxyPort),
                Credentials = new NetworkCredential(Username, Password)
            });

            var responseMessage = await httpClient.GetAsync(TargetUrl);
            var contentString = await responseMessage.Content.ReadAsStringAsync();

            return contentString;
        }
    }
}
