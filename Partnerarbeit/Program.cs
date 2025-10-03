using System;
using System.Collections.Generic;

namespace Partnerarbeit
{
    class Program
    {
        class Kontakt
        {
            public string firstname;
            public string lastname;
            public string email;
        }

        static void Main(string[] args)
        {
            bool weiter = true;
            int round = 0;
            List<Kontakt> kontakte = new List<Kontakt>();
            string filePath = @"C:\Users\eliob\Documents\Basislehrjahr\C#\Kontakte.txt";


            Console.WriteLine("*********************");
            Console.WriteLine("* Kontakte erfassen *");
            Console.WriteLine("*********************");

            while (weiter)
            {
                Console.WriteLine();
                Console.Write("Eingabe beenden? (j/n): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "j")
                {
                    weiter = false;
                }
                else if (input.ToLower() == "n")
                {
                    Console.WriteLine();
                    Console.WriteLine($"{round + 1}. Kontakt");
                    Kontakt kontakt = new Kontakt();
                    Console.Write("Vorname: ");
                    kontakt.firstname = Console.ReadLine();
                    Console.Write("Nachname: ");
                    kontakt.lastname = Console.ReadLine();
                    Console.Write("E-Mail: ");
                    kontakt.email = Console.ReadLine();
                    
                    kontakte.Add(kontakt);


                    round++;
                }
            }

            Console.Clear();
            Console.Write("Wie sollen die Kontakte ausgegeben werden? Vor- oder Nachname zuerst? (v/n): ");
            string output = Console.ReadLine();
            foreach (Kontakt k in kontakte)
            {
                if (output.ToLower() == "v")
                {
                    Console.WriteLine(k.firstname + " " + k.lastname + " (" + k.email + ")");
                }
                else if (output.ToLower() == "n")
                {
                    Console.WriteLine(k.lastname + " " + k.firstname + " (" + k.email + ")");
                }
            }

            Console.WriteLine("Sollen diese Kontakte nun exportiert werden? (j/n)");
            string export = Console.ReadLine();

            if (export.ToLower() == "j")
            {
                List<string> kontaktZeilen = new List<string>();
                for (int i = 0; i < round; i++)
                {
                    if (output.ToLower() == "v")
                    {
                        kontaktZeilen.Add($"{kontakte[i].firstname} {kontakte[i].lastname} ({kontakte[i].email})");
                    }
                    else if (output.ToLower() == "n")
                    {
                        kontaktZeilen.Add($"{kontakte[i].lastname} {kontakte[i].firstname} ({kontakte[i].email})");
                    }
                }

                File.WriteAllLines(filePath, kontaktZeilen);
                Console.WriteLine("Die Kontakte wurden exportiert.");
            }
        }
    }
}