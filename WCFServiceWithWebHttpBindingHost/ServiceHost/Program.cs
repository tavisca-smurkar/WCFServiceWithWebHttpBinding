using System;
using System.ServiceModel;
using WCFServiceWithWebHttpBindingHost;
namespace HelloServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using ( ServiceHost host = new ServiceHost(typeof(HelloService)))
            {
                host.Open();
                Console.WriteLine("Service is started at {0}", DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
