using System;

namespace T3_Kulutus
{
    class Program
    {
        static void Main(string[] args)
        {
            double kulutus = 7.5;            
            double bensaLHinta = 1.55;
            double kilometrit = 0;

            kulutus = kulutus / 100;

            Console.WriteLine("Anna kuljettujen kilometrien määrä");
            kilometrit = int.Parse(Console.ReadLine());

            kulutus = kilometrit * kulutus;
            bensaLHinta = kulutus * bensaLHinta;

            Console.WriteLine("Polttoainetta kulutettu: " + kulutus + " litraa" + " ja se maksoi: " + bensaLHinta + " euroa");
        }
    }
}
