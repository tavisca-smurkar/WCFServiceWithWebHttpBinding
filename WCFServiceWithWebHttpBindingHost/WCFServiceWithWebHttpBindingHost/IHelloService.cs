using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
namespace WCFServiceWithWebHttpBindingHost
{
    [ServiceContract]
    public interface IHelloService
    {
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/{name}")]
        [OperationContract]
        string GetMessage(string name);
    }
}
