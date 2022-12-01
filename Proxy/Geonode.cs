using System;
using System.Net;
using System.Net.Http;

namespace Proxy
{
    public class Geonode
    {
        private const string Username = "geonode_HtmfRb2EBu";

        private const string Password = "2b020ad4-0659-4071-89f0-7dcfab185680";

        private const string GeonodeDns = "http://50.47.75.213:5768";

        private const string UrlToGet = "http://ip-api.com/json";

        public Geonode()
        {
            TestPorxyRequest();
        }

        public static void TestPorxyRequest()
        {
            using var httpClient = new HttpClient(new HttpClientHandler
            {
                Proxy = new WebProxy(GeonodeDns),
                Credentials = new NetworkCredential(Username, Password)
            });

            using var responseMessage = httpClient.GetAsync(UrlToGet);

            var contentString = responseMessage.Result;

            Console.ReadKey(true);
        }
    }
}
