namespace Aufgabe2;

class Program
{
    static void Main(string[] args)
    {
        int days;
        int secs;


        Console.WriteLine("Berechnung von Sekunden eines Monats in Abhängigkeit seiner Anzahl Tage");
        Console.WriteLine("-------------------------------------------------------------------------");

        while (true)
        {
            Console.WriteLine("Wieviele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen?");
            string input = Console.ReadLine();

            if (int.TryParse(input, out days) && days >= 28 && days <= 31)
            {
                secs = (days * 86400);
                Console.WriteLine("Ein Monat mit " + days + " Tagen hat " + secs + " Sekunden.");
                break;
            }
            else
            {
                Console.WriteLine("Your Number is invalid. Try agian:");
            }

            secs = (days * 86400);
            
        }
    }
}

    
