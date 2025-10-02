using System;

namespace Aufgabe18
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vokale = { 'a','e','i','o','u','ä','ö','ü','A','E','I','O','U','Ä','Ö','Ü' };

            Console.WriteLine("Deine Eingabe:");
            Console.WriteLine();
            string eingabe = Console.ReadLine();

            int gesamt = 0;

            for (int i = 0; i < vokale.Length; i++)
            {
                int anzahl = 0;

                for (int j = 0; j < eingabe.Length; j++)
                {
                    if (eingabe[j] == vokale[i])
                    {
                        anzahl++;
                        gesamt++;
                    }
                }

                if (anzahl > 0)
                {
                    Console.WriteLine("Der Vokal " + vokale[i] + " kommt " + anzahl + " mal vor.");
                }
            }

            Console.WriteLine("Dein Text hat total " + gesamt + " Vokale.");
        }
    }
}