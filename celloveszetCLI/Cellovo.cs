using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetCLI
{
    public class Cellovo
    {
        public String Nev { get; private set; }
        public int elsoloves { get; private set; }
        public int masodikloves { get; private set; }
        public int harmadikloves { get; private set; }
        public int negyedikloves { get; private set; }
        public Cellovo(string sor)
        {
            string[] darabok = sor.Split(';');
            Nev = darabok[0];
            this.elsoloves = int.Parse(darabok[1]);
            this.masodikloves = int.Parse(darabok[2]);
            this.harmadikloves = int.Parse(darabok[3]);
            this.negyedikloves = int.Parse(darabok[4]);
        }
        public int legnagyobb()
        {
            return Math.Max(elsoloves,
                Math.Max(masodikloves,
                Math.Max(negyedikloves, harmadikloves)));
            //legnagyobb értékű lövést
        }
    }
}
