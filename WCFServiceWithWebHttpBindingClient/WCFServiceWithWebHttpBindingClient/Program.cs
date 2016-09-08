using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using WCFServiceWithWebHttpBindingClient.Client;

namespace WCFServiceWithWebHttpBindingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using ( Client.EmployeeServiceClient client = new Client.EmployeeServiceClient("BasicHttpBinding_IEmployeeService"))
            {
                client.SaveEmployee(new Client.PermanentEmployee { Id = "4", Name = "Hritik", DateOfBirth = DateTime.Now, Gender = Client.Gender.Male });
                //Console.WriteLine(client.GetEmployee("4"));

                Console.WriteLine(Serializer.Serialize(client.GetEmployee("4")));
                Console.WriteLine("********");

                var data = Serializer.Serialize(client.GetEmployee("4"));

                Console.WriteLine(Deserializer.Deserialize<PermanentEmployee>(data));
            }
        }
    }
    
   public static class Serializer
    {
            public static string Serialize(Object ob)
            {
                using (System.IO.MemoryStream memory = new System.IO.MemoryStream())
                {
                    DataContractSerializer serializer = new DataContractSerializer(ob.GetType());
                    {
                        serializer.WriteObject(memory,ob);
                        return Encoding.UTF8.GetString(memory.ToArray());
                    }

                }
                   
            }
    }


    public static class Deserializer
    {
        public static T Deserialize<T>(string data)
        {
            DataContractSerializer deserializer = new DataContractSerializer(typeof(T));

         return (T)deserializer.ReadObject(System.Xml.XmlReader.Create(new System.IO.StringReader(data)));
        }
    }

}
