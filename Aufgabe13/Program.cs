namespace Aufgabe13;

class Program
{
    static void Main(string[] args)
    {
        int length;
        
        Console.WriteLine("Wie lang soll die Linie sein?");
        Console.Write("Deine Eingabe: ");
        length = Convert.ToInt32(Console.ReadLine());

        for (int zeile = 0; zeile < length; zeile++)
        {
            for (int spalte = 0; spalte < length; spalte++)
            {
                if (spalte == zeile)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}