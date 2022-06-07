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
            //1.Constructor Injection
            _iService1 = injectedService;
        }

        public void InjectService(IService injectedService)
        {
            //2.Method Injection 
            _iService1 = injectedService;
        }

        public IService Service
        {
            //3.Property Injection
            set { _iService1 = value; }
        }

        private IService _iService1 = null;

        public void UseService()
        {
            _iService1?.UsefulMethod();
        }
    }
}
