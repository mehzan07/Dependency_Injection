using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Client
    {
        public IService iService;

        public Client(IService injectedService)
        {
            iService = injectedService;
        }
    }
}
