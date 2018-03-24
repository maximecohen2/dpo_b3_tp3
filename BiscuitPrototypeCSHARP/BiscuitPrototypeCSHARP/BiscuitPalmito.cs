using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiscuitPrototypeCSHARP
{
    public class BiscuitPalmito : Biscuit
    {
        private int nbOreilles;


        public override Biscuit Clone()
        {
            return (Biscuit)this.MemberwiseClone(); // copie membre à membre par défaut
        }


        public int NbOreilles { get => nbOreilles; set => nbOreilles = value; }
    }
}
