using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojisteni
{
    internal class Databaze
    {
        private List<Zakaznik> zakaznici;

        public Databaze()
        {
            zakaznici = new List<Zakaznik>();
        }

        public void PridejZakaznika(string jmeno, string prijmeni, int vek, int telCislo)
        {
            zakaznici.Add(new Zakaznik(jmeno, prijmeni, vek, telCislo));
        }

        public List<Zakaznik> VyhledatZakazniky()
        {
            List<Zakaznik> nalezene = new List<Zakaznik>();
            foreach (Zakaznik zakaznik in zakaznici)
                nalezene.Add(zakaznik);
            return nalezene;
        }

        public List<Zakaznik> VyhledatZakaznika(string jmeno, string prijmeni)
        {
            List<Zakaznik> nalezeno = new List<Zakaznik>();
            foreach (Zakaznik zakaznik in zakaznici)
            {
                if ((zakaznik.Jmeno == jmeno) && (zakaznik.Prijmeni == prijmeni))
                        nalezeno.Add(zakaznik);
            }
            return nalezeno;
        }
    }
}
