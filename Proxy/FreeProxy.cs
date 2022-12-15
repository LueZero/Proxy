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
        public FreeProxy(string proxyHost = "161.35.223.83", int proxyPort = 80)
        {
            // https://www.freeproxylists.net/zh/
            ProxyHost = proxyHost;
            ProxyPort = proxyPort;
        }
    }
}
