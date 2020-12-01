using System;

namespace T4_Palindromi
{
    class Program
    {
        static void Main(string[] args)
        {
            string ekasana;
            string tokasana;

            Console.WriteLine("Anna palidromi: ");
            ekasana = Console.ReadLine();

            char[] kirjain = ekasana.ToCharArray();
            Array.Reverse(kirjain);
            tokasana = new string(kirjain);

            if (ekasana.Equals(tokasana))
            {
                Console.WriteLine("Sana on palidromi");
            }
            else
            {
                Console.WriteLine("Sana ei ole palidromi");
            }                                   
        }
    }
}
