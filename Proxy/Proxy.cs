using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Proxy
    {
        public string MyProxyHost {get;set;}

        public int MyProxyPort { get; set; }

        public string TargetUrl = "http://ip-api.com/json";

        public virtual async Task<string> GetPorxyRequest()
        {
            using var httpClient = new HttpClient(new HttpClientHandler
            {
                Proxy = new WebProxy(MyProxyHost, MyProxyPort)
            });

            var responseMessage = await httpClient.GetAsync(TargetUrl);
            var contentString = await responseMessage.Content.ReadAsStringAsync();

            return contentString;
        }
    }
}
