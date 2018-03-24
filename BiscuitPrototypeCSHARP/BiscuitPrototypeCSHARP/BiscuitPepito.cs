using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiscuitPrototypeCSHARP
{
    class BiscuitPepito : Biscuit
    {
        private String typeChoco;


        public override Biscuit Clone()
        {
            return (Biscuit)this.MemberwiseClone(); // copie membre à membre par défaut
        }


        public String TypeChoco { get => typeChoco; set => typeChoco = value; }
    }
}
