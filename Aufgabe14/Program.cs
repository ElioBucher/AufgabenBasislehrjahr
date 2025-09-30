namespace Aufgabe14;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prüfen, ob es sich beieinem Jahr um ein Schaltjahr handelt.");
        Console.WriteLine("###########################################################");

        while (true)
        {
            Console.Write("Eingabe Jahr (q to quit): ");
            string input = Console.ReadLine();
            Console.WriteLine();

            if (input == "q")
            {
                Console.WriteLine("Quit...");
                break;
            }

            if (int.TryParse(input, out int jahr))
            {
                if (jahr > 1400 && IstSchaltjahr(jahr))
                {
                    Console.WriteLine("Das Jahr " + input + " ist ein Schaltjahr.");
                }
                else
                {
                    Console.WriteLine("Das Jahr " + input + " ist KEIN Schaltjahr.");
                }
            }

            static bool IstSchaltjahr(int jahr)
            {
                return (jahr % 4 == 0 && jahr % 100 != 0) || (jahr % 400 == 0);
            }
        }
    }
}