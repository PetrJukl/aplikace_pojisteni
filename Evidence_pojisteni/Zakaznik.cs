using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojisteni
{
    internal class Zakaznik
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }
        public int TelCislo { get; set; }

        public Zakaznik (string jmeno, string prijmeni, int vek, int telCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelCislo = telCislo;
        }

        public override string ToString()
        {
            return String.Format("{0,-12} {1,-12} {2,-3} {3,18}", Jmeno, Prijmeni, Vek, TelCislo);
        }
    }
}
