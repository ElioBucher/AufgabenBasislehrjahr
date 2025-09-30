namespace Aufgabe10;

class Program
{
    static void Main(string[] args)
    {
        BerechneQuersumme();
    }

    static int BerechneQuersumme()
    {
        int number;
        int sum = 0;

        Console.WriteLine("Zahl: ");
        Console.WriteLine(" ");
        number = Convert.ToInt32(Console.ReadLine());
        

        while (number != 0)
        {
            sum = sum + (number % 10);
            number = number / 10;
        }

        Console.WriteLine("Quersumme: " + sum);
        return sum;
    }
}