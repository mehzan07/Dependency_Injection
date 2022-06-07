using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class S: IS
    {
        public IU obj_iu = null;
        public IV obj_iv = null;

        public S(IU injectIU, IV injectIV)
        {
            obj_iu = injectIU;
            obj_iv = injectIV;
        }
    }
}
