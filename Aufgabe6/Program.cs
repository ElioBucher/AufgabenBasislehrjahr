namespace Aufgabe6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----------");
        Console.WriteLine("Kleines 1x1");
        Console.WriteLine("-----------");
        
        for (int i = 1; i <= 100; i++)
        {
            Console.Write(i + "\t");
            if (i % 10 == 0)
            {
                Console.WriteLine(" ");
            }
        }
    }
}