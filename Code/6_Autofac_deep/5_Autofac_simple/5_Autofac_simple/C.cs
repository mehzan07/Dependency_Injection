using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{    

    public class C
    {
        public IS obj_is = null;
        public IT obj_it = null;

        public C(IS injectIs, IT injectIT)
        {
            obj_is = injectIs; 
            obj_it = injectIT;
        }
    }
}
