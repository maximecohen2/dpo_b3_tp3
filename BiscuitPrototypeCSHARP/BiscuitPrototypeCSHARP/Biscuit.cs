using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiscuitPrototypeCSHARP
{
    public abstract class Biscuit : ICloneable
    {
        public abstract Biscuit Clone();


        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }
    }
}

