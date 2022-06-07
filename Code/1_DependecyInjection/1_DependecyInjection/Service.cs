using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DependecyInjection
{
    public class Service : IService
    {
        void IService.UsefulMethod()
        {
            //some usefull work
            Console.WriteLine("Service-UsefulMethod");
        }
    }
}
