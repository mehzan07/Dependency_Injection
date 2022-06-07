using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DependecyInjection
{
    public class Client
    {
        public Client(IService injectedService=null)
        {
            //Constructor Injection
            _iService1 = injectedService;
        }

        private IService _iService1 = null;

        public void UseService()
        {
            _iService1?.UsefulMethod();
        }
    }
}
