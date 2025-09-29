namespace Aufgabe5;

class Program
{
    static void Main(string[] args)
    {
        double km;
        bool ready = false;
        
        Console.WriteLine("Wie viele Kilometer möchtest du laufen?");
        Console.WriteLine(" ");
        km = Convert.ToInt32(Console.ReadLine());

        double rounds = (km * 2.5);
        if (km > 42)
        {
            Console.WriteLine("Das schaffst du nicht...");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Das sind " + rounds + " Runden. Bereit für den Lauf? (Ja/Nein)");
            string bereit = Console.ReadLine();

            if (bereit == "Ja" || bereit == "ja")
            {
                ready = true;
            } else if (bereit == "Nein" || bereit == "nein")
            {
                Console.WriteLine("Schwach");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Falsche Eingabe...");
            }

        

        }

        for (int i = 1; i <= rounds; i++)
        {
            Console.WriteLine("Du läufst Runde " + i);
        }

        
        Console.WriteLine("Du hast es geschafft!");
        
    }
}