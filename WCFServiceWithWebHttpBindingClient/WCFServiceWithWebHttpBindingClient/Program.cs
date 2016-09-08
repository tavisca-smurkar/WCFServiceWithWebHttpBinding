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
            using ( Client.EmployeeServiceClient client = new Client.EmployeeServiceClient("BasicHttpBinding_IEmployeeService"))
            {
                client.SaveEmployee(new Client.Employee { Id = "4", Name = "Hritik", DateOfBirth = DateTime.Now, Gender = Client.Gender.Male });
                Console.WriteLine(client.GetEmployee("4"));
            }
        }
    }
    
}
