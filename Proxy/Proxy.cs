using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Proxy
    {
        public string ProxyHost {get;set;}

        public int ProxyPort { get; set; }

        public string TargetUrl = "http://ip-api.com/json";

        protected HttpClient HttpClient;

        private void SetHeaders(Dictionary<string, string> headers)
        {
            if (headers != null)
                foreach (var header in headers)
                    HttpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
        }

        public virtual async Task<string> GetProxyRequest(Dictionary<string, string> headers = null)
        {
            HttpClient = new HttpClient(new HttpClientHandler { Proxy = new WebProxy(ProxyHost, ProxyPort) });

            SetHeaders(headers);

            var responseMessage = await HttpClient.GetAsync(TargetUrl);
            var contentString = await responseMessage.Content.ReadAsStringAsync();

            return contentString;
        }

        public virtual async Task<string> PostProxyRequest(HttpContent content, Dictionary<string, string> headers = null)
        {
            HttpClient = new HttpClient(new HttpClientHandler { Proxy = new WebProxy(ProxyHost, ProxyPort) });

            SetHeaders(headers);

            var responseMessage = await HttpClient.PostAsync(TargetUrl, content);
            var contentString = await responseMessage.Content.ReadAsStringAsync();

            return contentString;
        }

        public virtual async Task<string> GetIps(HttpContent content)
        {
            var responseMessage = await HttpClient.PostAsync(TargetUrl, content);

            var contentString = await responseMessage.Content.ReadAsStringAsync();

            return contentString;
        }
    }
}
