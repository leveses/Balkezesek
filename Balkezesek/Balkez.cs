using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    class Balkez
    {
        public string Nev { get; private set; }
        public string ElsoP { get; private set; }
        public string UtolsoP { get; private set; }
        public int Suly { get; private set; }
        public int Magassag { get; private set; }

        public Balkez(string n)
        {
            string[] sor = n.Split(';');
            Nev = sor[0];
            ElsoP = sor[1];
            UtolsoP = sor[2];
            Suly = int.Parse(sor[3]);
            Magassag = int.Parse(sor[4]);
        }
    }
}
