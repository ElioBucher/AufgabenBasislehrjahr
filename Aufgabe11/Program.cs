namespace Aufgabe11;

class Program
{
    static void Main(string[] args)
    {
        int number1;
        int number2;

        Console.WriteLine("Number 1: ");
        Console.WriteLine(" ");
        number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Number 2: ");
        number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine($"| {"Zahl",-7} | {"Quersumme",-11} | {"Zahl / Quersumme",-17}   |");
        Console.WriteLine("-----------------------------------------------");
        
        
        int start = Math.Min(number1, number2);
        int end = Math.Max(number1, number2);

        for (int i = start; i <= end; i++)
        {
            int crosssum = 0;
            int copie = i;
            while (copie != 0)
            {
                crosssum += copie % 10;
                copie /= 10;
            }

            if (i % crosssum == 0)
            {
                double div = (double)i / crosssum;
                Console.WriteLine($"| {i,-7} | {crosssum,-11} | {div,-17:F0}   |");
                Console.WriteLine("-----------------------------------------------");
            }
        }
    }
}