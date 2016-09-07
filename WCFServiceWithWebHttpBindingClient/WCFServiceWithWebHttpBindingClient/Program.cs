using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace WCFServiceWithWebHttpBindingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using ( Client.EmployeeServiceClient client = new Client.EmployeeServiceClient("WSHttpBinding_IEmployeeService"))
            {
                Console.WriteLine(client.GetEmployee("1").Name);
            }
        }
    }
}
