namespace Aufgabe4;

class Program
{
    static void Main(string[] args)
    {
        string[] months =
        {
            "Januar", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November",
            "December"
        };

        Console.WriteLine("Write number (1-12): ");
        Console.WriteLine(" ");
        

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number >= 1 && number <= 12)
            {
                Console.WriteLine("Monat: " + months[number - 1]);

            }
            else
            {
                Console.WriteLine("The number must be between 1 and 12.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    
}
}