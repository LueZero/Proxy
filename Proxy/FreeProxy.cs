using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class FreeProxy : Proxy
    {
        public FreeProxy(string proxyHost = "93.20.25.100", int proxyPort = 80)
        {
            // https://www.freeproxylists.net/zh/
            ProxyHost = proxyHost;
            ProxyPort = proxyPort;
        }
    }
}
