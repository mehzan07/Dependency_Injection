using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class V: IV
    {
        public IX obj_ix = null;

        public V(IX injectIX)
        {
            obj_ix = injectIX;
        }
    }
}
