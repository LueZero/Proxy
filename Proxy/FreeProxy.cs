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
        public FreeProxy()
        {
            // https://www.freeproxylists.net/zh/
            MyProxyHost = "185.147.35.240";
            MyProxyPort = 80;
        }
    }
}
