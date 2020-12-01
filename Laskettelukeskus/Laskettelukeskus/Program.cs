using System;

namespace Laskettelukeskus
{
    class Program
    {
        static void Main(string[] args)
        {
            int kokoPäivä = 55;
            int puoliPäivä = 35;
            int suksiVuokra = 20;
            int lautavuokra = 25;
            int lippuhinta = 0;
            int vuokrahinta = 0;
            int loppuhinta = 0;
            int määrä = 0;
            string käyttäjänSyöte;
            string jatko = "K";

            while (jatko == "K")
            {               
                Console.WriteLine("Ostatko lipun? K/E");
                käyttäjänSyöte = Console.ReadLine();

                if (käyttäjänSyöte == "K")
                {
                    Console.WriteLine("Haluatko kokopäivän(KP) vai puolenpäivän(PP)lipun");
                    käyttäjänSyöte = Console.ReadLine();

                    if (käyttäjänSyöte == "KP")
                    {
                        Console.WriteLine("Kokopäivänlipun hinta: " + kokoPäivä);
                        Console.WriteLine("Kuinka monta lippua haluat: ");
                        määrä = int.Parse(Console.ReadLine());                       
                        lippuhinta =+ kokoPäivä * määrä;                       
                    }

                    if (käyttäjänSyöte == "PP")
                    {
                        Console.WriteLine("Puolenpäivänlipun hinta: " + puoliPäivä);
                        Console.WriteLine("Kuinka monta lippua haluat: ");
                        määrä = int.Parse(Console.ReadLine());
                        lippuhinta =+ puoliPäivä * määrä;
                    }
                }

                else if (käyttäjänSyöte == "E")
                {
                    Console.WriteLine("Jatketaan välinevuokraamoon");
                }

                Console.WriteLine("Tervetuloa välinevuokraamoon, tarvitsetko vlineitä? K/E");
                käyttäjänSyöte = Console.ReadLine();

                if (käyttäjänSyöte == "K")
                {
                    Console.WriteLine(" Otatko sukset(SV) vai Laudan(LV)");
                    käyttäjänSyöte = Console.ReadLine();

                    if (käyttäjänSyöte == "SV")
                    {
                        Console.WriteLine("Suksien vuokraus maksaa: " + suksiVuokra);
                        Console.WriteLine("Kuinka monta paria suksia haluat: ");
                        määrä = int.Parse(Console.ReadLine());
                        vuokrahinta =+ suksiVuokra * määrä;
                    }

                    if (käyttäjänSyöte == "LV")
                    {
                        Console.WriteLine("Laudan vuokraus maksaa: " + lautavuokra);
                        Console.WriteLine("Kuinka monta lautaa haluat: ");
                        määrä = int.Parse(Console.ReadLine());
                        vuokrahinta =+ lautavuokra * määrä;
                    }
                }

                else if (käyttäjänSyöte == "E")
                {
                    Console.WriteLine("Jatketaan kassalle");
                }
               
                Console.WriteLine("Jatketaanko ostoksia K/E");
                käyttäjänSyöte = Console.ReadLine();

                if (käyttäjänSyöte == "K")
                {
                    Console.WriteLine("Palataan alkuun");
                }

                else if (käyttäjänSyöte == "E")
                {
                    loppuhinta = lippuhinta + vuokrahinta;
                    Console.WriteLine("Loppusumma:" + loppuhinta);
                    jatko = Console.ReadLine();
                }

            }           
        }
    }
}
