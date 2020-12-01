using System;

namespace T2_Mäkihyppy
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] pisteet = new int[5];
            int suurinpiste = int.MinValue;
            int pieninpiste = int.MaxValue;
            int miinuspisteet = 0;
            int summa = 0;
            int loppupisteet = 0;

            for (int i = 0; i < pisteet.Length; i++)
            {
                Console.WriteLine("Anna {0}. pisteet:", i + 1);
                pisteet[i] = int.Parse(Console.ReadLine());
                summa += pisteet[i];
            }
            Console.WriteLine("Pisteet yhteensä: " + summa);

            foreach (int i in pisteet)
            {
                if (i > suurinpiste)
                {
                    suurinpiste = i;
                }
            }
            Console.WriteLine("Suurimmatpisteet: " + suurinpiste);

            foreach (int i in pisteet)
            {
                if (i < pieninpiste)
                {
                    pieninpiste = i;
                }
            }
            Console.WriteLine("Pienimmätpisteet: " + pieninpiste);

            miinuspisteet = suurinpiste + pieninpiste;
            Console.WriteLine("Miinuspisteet: " + miinuspisteet);

            loppupisteet = summa - miinuspisteet;
            Console.WriteLine("Lopullinen pistemäärä: " + loppupisteet);
        }
    }
}