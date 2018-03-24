using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiscuitPrototypeCSHARP
{
    public class MachineABiscuit
    {
        private Biscuit biscuit;

        public MachineABiscuit(Biscuit biscuit)
        {
            this.biscuit = biscuit;
        }

        public Biscuit FairePaquetBiscuit(Biscuit biscuit)
        {
            return biscuit.Clone();
        }

        static void Main(string[] args)
        {
            Biscuit tempPepito = null;
            Biscuit tempPalmito = null;
            Biscuit pepito = new BiscuitPepito();
            Biscuit palmito = new BiscuitPalmito();
            MachineABiscuit paquetPepito = new MachineABiscuit(pepito);
            MachineABiscuit paquetPalmito = new MachineABiscuit(palmito);

            for (int i = 0; i < 25; i++)
                tempPepito = paquetPepito.FairePaquetBiscuit(pepito);
                tempPalmito = paquetPalmito.FairePaquetBiscuit(palmito);

            // Display the number of command line arguments:

            System.Console.WriteLine(tempPalmito);
            System.Console.WriteLine(tempPepito);
        }


        
        }


    }

