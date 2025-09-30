namespace Aufgabe15;

class Program
{
    static void Main(string[] args)
    {
        int widthtribe;
        int heighttribe;
        int heightcrown;
        bool tribeready = false;


        Console.WriteLine();
        Console.Write("Breite des Stammes? ");
        widthtribe = Convert.ToInt32(Console.ReadLine());
        Console.Write("Höhe des Stammes? ");
        heighttribe = Convert.ToInt32(Console.ReadLine());
        Console.Write("Höhe der Krone? ");
        heightcrown = Convert.ToInt32(Console.ReadLine());

        for (int row = 0; row < heightcrown; row++)
        {
            for (int space = 0; space < heightcrown - row - 1; space++)
            {
                Console.Write(" ");
            }

            for (int star = 0; star < 2 * row + 1; star++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for (int row = 0; row < heighttribe; row++)
        {
            for (int space = 0; space < (2 * heightcrown - 1 - widthtribe) / 2; space++)
            {
                Console.Write(" ");
            }
            for (int col = 0; col < widthtribe; col++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        
    }
}