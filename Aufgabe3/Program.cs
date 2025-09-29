namespace Aufgabe3;

class Program
{
    static void Main(string[] args)
    {
        int i = 1;

        if (i > 10)
        {
            Environment.Exit(0);
        }
        else
        {
            while (i <= 10)
            {
                Console.WriteLine(i++);
            }
            }


        }
    }
