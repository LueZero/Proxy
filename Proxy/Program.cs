using System;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var freeProxy = new FreeProxy();

            Task.Run(async () =>
            {
                var result = freeProxy.GetPorxyRequest();
                Console.WriteLine("Response:" + result.Result);
                Console.ReadKey(true);
            }).Wait();
        }
    }
}