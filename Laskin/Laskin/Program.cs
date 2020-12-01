using System;

namespace Laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            String lasku;
            int x = 0;
            int y = 0;
            Double tulos;

            Console.Write("Anna laskutoimitus summa/erotus/tulo/osamäärä/jakojäännös: ");
            lasku = Console.ReadLine();

            Console.Write("Anna ensimmäinen luku: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Anna toinen luku: ");
            y = int.Parse(Console.ReadLine());

            if (lasku == "summa")
            {
                tulos = x + y;
                Console.WriteLine("Tulos = " + tulos);
            }

             else if (lasku == "erotus")
            {
                tulos = x - y;
                Console.WriteLine("Tulos = " + tulos);
            }

            else if (lasku == "tulo")
            {
                tulos = x * y;
                Console.WriteLine("Tulos = " + tulos);
            }

            else if (lasku == "osamäärä")
            {
                tulos = x / y;
                Console.WriteLine("Tulos = " + tulos);
            }

            else if (lasku == "jakojäännös")
            {
                tulos = x % y;
                Console.WriteLine("Tulos = " + tulos);
            }


        }
    }
}
