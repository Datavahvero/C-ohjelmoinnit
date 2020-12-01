using System;

namespace T1_Koulunumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna pisteet");
            int pisteet;
            string rivi = Console.ReadLine();
            bool tulos = Int32.TryParse(rivi, out pisteet);
            if (tulos)
            {
                switch (pisteet)
                {
                    case 0:
                    case 1: Console.WriteLine("Arvosanasi on 0"); break;
                    case 2:
                    case 3: Console.WriteLine("Arvosanasi on 1"); break;
                    case 4:
                    case 5: Console.WriteLine("Arvosanasi on 2"); break;
                    case 6:
                    case 7: Console.WriteLine("Arvosanasi on 3"); break;
                    case 8:
                    case 9: Console.WriteLine("Arvosanasi on 4"); break;
                    case 10:
                    case 11: Console.WriteLine("Arvosanasi on 5"); break;
                }
            }
            else
            {
                Console.WriteLine("Anna numero");
            }
        }
    }
}
