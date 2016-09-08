using System;
using System.ServiceModel;
using WCFServiceWithWebHttpBindingHost;
namespace HelloServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost hostOne = new ServiceHost(typeof(EmployeeService));
            hostOne.Open();
            Console.WriteLine("Service is started at {0}", DateTime.Now);
            Console.ReadLine();
            hostOne.Close();

                    }
    }
}
