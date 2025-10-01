namespace Aufgabe16;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        bool play = true;


        while (play)
        {
            int rndmnumber = rnd.Next(1, 101);
            int inputnumber;
            int round = 0;
            bool guessed = false;

            Console.WriteLine("Deine Zahl (1...100): ");
            Console.WriteLine(" ");


            while (!guessed)
            {
                round++;
                string input = Console.ReadLine();
                if (int.TryParse(input, out inputnumber))
                {
                    if (inputnumber < rndmnumber)
                    {
                        Console.WriteLine("Zahl ist zu klein! Nächster Versuch: ");
                    }

                    else if (inputnumber > rndmnumber)
                    {
                        Console.WriteLine("Zahl ist zu gross! Nächster Versuch: ");
                    }
                    else if (inputnumber == rndmnumber)
                    {
                        Console.WriteLine("Die Zahl stimmt! Du hast Total " + round +
                                          " Versuche benötigt. Nocheinmal spielen? [y/n]");
                        guessed = true;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe! Bitte gib eine Zahl ein.");
                }
            }

            Console.WriteLine("Nocheinmal spielen? [y/n]");
            string again = Console.ReadLine();
            play = (again.ToLower() == "y");
        }
    }
}