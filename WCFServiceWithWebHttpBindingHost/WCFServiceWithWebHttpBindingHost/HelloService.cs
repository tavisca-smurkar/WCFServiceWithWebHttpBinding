﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceWithWebHttpBindingHost
{
    public class HelloService : IHelloService
    {
        public string GetMessage(string name)
        {
            return "Hello {name}";
        }
    }
}
