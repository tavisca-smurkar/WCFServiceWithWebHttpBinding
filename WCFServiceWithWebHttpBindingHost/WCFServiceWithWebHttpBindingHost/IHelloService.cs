﻿using System;
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
        [OperationContract]
        [WebInvoke(ResponseFormat =WebMessageFormat.Json , UriTemplate = "/{name}")]
        string GetMessage(string name);
    }
}
