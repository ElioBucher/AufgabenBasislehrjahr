namespace Aufgabe9;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        while (quit == false)
        {
            Console.WriteLine("Ganzzahlige Dezimalzahl (q to Quit):");
            Console.WriteLine("");

            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                quit = true;
            }
            else
            {
                if (int.TryParse(input, out int n))
                {
                    string bin = "";

                    int zahl = n;
                    while (zahl > 0)
                    {
                        int rest = zahl % 2;
                        bin = rest + bin;
                        zahl /= 2;
                    }

                    if (bin == "")
                    {
                        bin = "0";
                    }

                    Console.WriteLine("Binär: " + bin);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe, bitte Zahl oder q eingeben...");
                }
            }
        }

        {
        }
    }
}
