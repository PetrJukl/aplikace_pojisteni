using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojisteni
{
    internal class Aplikace
    {
        private Databaze databaze;

        public Aplikace()
        {
            this.databaze = new Databaze();
        }

        public void PridejZakaznika()
        {
            string jmeno;
            string prijmeni;
            int vek;
            int telCislo;

            Console.WriteLine("Zadejte jméno pojištěného:");
            while (string.IsNullOrEmpty(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Zadej jméno znovu:");
            }
            Console.WriteLine("Zadejte příjmení:");
            while (string.IsNullOrEmpty(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte příjmení znovu:");
            }
            Console.WriteLine("Zadejte věk:");
            while (!int.TryParse(Console.ReadLine(), out vek))
            { 
                Console.WriteLine("Zadali jste neplatnou hodnotu, zadejte věk znovu:");
            }
            Console.WriteLine("Zadejte telefonní číslo: ");
            while (!int.TryParse(Console.ReadLine(), out telCislo))
            {
                Console.WriteLine("Zadali jste neplatnou hodnotu, zadejte číslo znovu:");   
            } 
            databaze.PridejZakaznika(jmeno, prijmeni, vek, telCislo);
            Console.WriteLine(Environment.NewLine + "Data byla uložena. Pokračujte libovolnou klávesou...");
        }

        public void VypsatZakazniky()
        {
            List<Zakaznik> zakazniks = databaze.VyhledatZakazniky();

            if (zakazniks.Count() > 0)
            {
                foreach (Zakaznik zakaznik in zakazniks)
                {
                    Console.WriteLine(zakaznik);
                }
                Console.WriteLine(Environment.NewLine + "Pokračujte libovolnou klávesou...");
            }
            else
                Console.WriteLine("Nebyly nalezeny žádné záznamy.");
        }

        public void VypsatZakaznika()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = Console.ReadLine();
            List<Zakaznik> zakazniks = databaze.VyhledatZakaznika(jmeno, prijmeni);
            
            if (zakazniks.Count() > 0)
            {
                foreach (Zakaznik zakaznik in zakazniks)
                    Console.WriteLine(zakaznik);
                Console.WriteLine(Environment.NewLine + "Pokračujte libovolnou klávesou...");
            }
            else
                Console.WriteLine("Nebyl nalezen žádný pojištěný.");
        }

        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("------------------------------");
        }
    }
}
