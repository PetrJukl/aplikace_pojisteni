namespace Evidence_pojisteni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aplikace aplikace = new Aplikace();
            char volba = '0';
            
            while (volba != '4')
            {
                aplikace.VypisUvodniObrazovku();
                Console.WriteLine();
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine(Environment.NewLine);
                switch (volba)
                {
                    case '1':
                        aplikace.PridejZakaznika();
                        break;
                    case '2':
                        aplikace.VypsatZakazniky();
                        break;
                    case '3':
                        aplikace.VypsatZakaznika();
                        break;
                    case '4':
                        Console.WriteLine("Libovolnou klávesou ukončíte program...");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        break;
                }
                Console.ReadKey();

            }
            
        }
    }
}