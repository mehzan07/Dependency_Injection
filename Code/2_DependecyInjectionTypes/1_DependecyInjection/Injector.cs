using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DependecyInjection
{
    public class Injector
    {
        public Client ResolveClient()
        {            
            Service S=new Service();

            //NOTE: This is tutorial/demo code, normally you
            //implement only one of these 3 methods

            //1.Constructor Injection
            Client C = new Client(S);

            //2.Method Injection 
            C.InjectService(S);

            //3.Property Injection
            C.Service = S;

            return C;
        }        
    }
}
