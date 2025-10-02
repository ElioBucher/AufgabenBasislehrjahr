namespace Aufgabe19;

class Program
{
    static void Main(string[] args)
    {
        bool cal = true;

        while (cal == true)
        {
            Console.WriteLine("Make your calculation (+, -, /, *) only two numbers (or press Q to quit):");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "q")
            {
                break;
            }

            string[] parts = input.Split('+', '-', '*', '/');

            if (parts.Length == 2 && double.TryParse(parts[0], out double number1) &&
                double.TryParse(parts[1], out double number2))
            {
                double result = 0;

                if (input.Contains("+"))
                    result = number1 + number2;
                else if (input.Contains("-"))
                    result = number1 - number2;
                else if (input.Contains("*"))
                    result = number1 * number2;
                else if (input.Contains("/"))
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero");
                        break;
                    }

                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Error: Invalid input");
            }
        }
    }
}