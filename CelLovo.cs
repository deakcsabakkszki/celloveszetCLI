using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetCLI
{
    internal class CelLovo
    {
        public string nev { get; private set; }
        public int elsoloves { get; private set; }
        public int masodikloves { get; private set; }
        public int harmadikloves { get; private set; }
        public int negyedikloves { get; private set; }

        public CelLovo(string nev, int elsoloves, int masodikloves, int harmadikloves, int negyedikloves)
        {
            this.nev = nev;
            this.elsoloves = elsoloves;
            this.masodikloves = masodikloves;
            this.harmadikloves = harmadikloves;
            this.negyedikloves = negyedikloves;
        }

        public CelLovo(string sor)
        {
            string[] adatok = sor.Split(";");
            nev = adatok[0];
            elsoloves = int.Parse(adatok[1]);
            masodikloves = int.Parse(adatok[2]);
            harmadikloves = int.Parse(adatok[3]);
            negyedikloves = int.Parse(adatok[4]);
        }


    }
}
