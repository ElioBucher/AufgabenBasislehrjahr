using System;
using System.Threading;
using System.Timers;

namespace Waldbrand
{
    class Program
    {
        static System.Timers.Timer timer;
        static int fire;
        static int grow;
        static int height;
        static int width;
        static string[,] woods;
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //🌱
            //🌳
            //🔥
            //♨️
            //🪨
            //🟤 

            Console.WriteLine("Höhe des Waldes (Empfohlen 5-25): ");
            height = int.Parse(Console.ReadLine());

            Console.WriteLine("Breite des Waldes (Empfohlen " + height * 2 + "): ");
            width = int.Parse(Console.ReadLine());


            Console.WriteLine("Warscheinlichkeit der Funkenzündung (Empfohlen 1): ");
            fire = int.Parse(Console.ReadLine());

            Console.WriteLine("Warscheinlichkeit des Wachstums (Empfohlen 2): ");
            grow = int.Parse(Console.ReadLine());

            Console.Clear();
            woods = createWoods(width, height, random);
            printWoods(woods);


            timer = new System.Timers.Timer(1000);
            timer.Elapsed += TimerOnElapsed;
            timer.AutoReset = true;
            timer.Enabled = true;

            Console.ReadLine();
        }

        static readonly object consoleLock = new object();

        static void TimerOnElapsed(object? sender, ElapsedEventArgs e)
        {
            lock (consoleLock)
            {
                woods = catchFire(woods, fire, random);
                woods = treeGrow(woods, grow, random);
                woods = spreadFire(woods, random);
                woods = ashToSoil(woods);

                Console.Clear();
                printWoods(woods);
                Console.WriteLine("Drücke ENTER zum beenden...");
            }
        }

        static string[,] createWoods(int width, int height, Random random)
        {
            string[] allowed = new string[] { "🌳", "🪨", "🟤" };
            string[,] woods = new string[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int index = random.Next(allowed.Length);
                    woods[i, j] = allowed[index];
                }
            }

            return woods;
        }


        static void printWoods(string[,] woodsBig)
        {
            int height = woods.GetLength(0);
            int width = woods.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(woodsBig[i, j]);
                }

                Console.WriteLine();
            }
        }


        static string[,] catchFire(string[,] woods, int fire, Random random)
        {
            int height = woods.GetLength(0);
            int width = woods.GetLength(1);

            string[,] cloneWoods = (string[,])woods.Clone();


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if ((woods[i, j] == "🌳" || woods[i, j] == "🌱"))
                    {
                        int probability = random.Next(1, 101);
                        if (probability <= fire)
                        {
                            cloneWoods[i, j] = "🔥";
                        }
                    }
                }
            }

            return cloneWoods;
        }

        static string[,] spreadFire(string[,] woods, Random random)
        {
            int height = woods.GetLength(0);
            int width = woods.GetLength(1);
            string[,] cloneWoods = (string[,])woods.Clone();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (woods[i, j] == "🔥")
                    {
                        if (i > 0 && (woods[i - 1, j] == "🌳" || woods[i - 1, j] == "🌱"))
                            cloneWoods[i - 1, j] = "🔥";
                        if (i < height - 1 && (woods[i + 1, j] == "🌳" || woods[i + 1, j] == "🌱"))
                            cloneWoods[i + 1, j] = "🔥";
                        if (j > 0 && (woods[i, j - 1] == "🌳" || woods[i, j - 1] == "🌱"))
                            cloneWoods[i, j - 1] = "🔥";
                        if (j < width - 1 && (woods[i, j + 1] == "🌳" || woods[i, j + 1] == "🌱"))
                            cloneWoods[i, j + 1] = "🔥";

                        cloneWoods[i, j] = "️️♨️";
                        
                    }
                }
            }

            return cloneWoods;
        }

        static string[,] treeGrow(string[,] woods, int grow, Random random)
        {
            int height = woods.GetLength(0);
            int width = woods.GetLength(1);

            string[,] cloneWoods = new string [height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    cloneWoods[i, j] = woods[i, j];
                    int probability = random.Next(1, 101);

                    if (probability <= grow && (cloneWoods[i, j] == "🟤"))
                    {
                        cloneWoods[i, j] = "🌱";
                    }
                    else if (probability <= grow && (cloneWoods[i, j] == "🌱"))
                    {
                        cloneWoods[i, j] = "🌳";
                    }
                }
            }
            

            return cloneWoods;
        }
        static string[,] ashToSoil(string[,] woods)
        {
            int height = woods.GetLength(0);
            int width = woods.GetLength(1);
            string[,] cloneWoods = (string[,])woods.Clone();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (woods[i, j] == "♨️")
                    {
                        cloneWoods[i, j] = "🟤";
                    }
                }
            }

            return cloneWoods;
        }

    }
}