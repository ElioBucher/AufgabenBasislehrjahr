using System;
using System.Threading;

namespace WaldbrandEmoji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Zu wie viel Prozent soll ein Baum anfangen zu brennen: ");
            int treeBurn = int.Parse(Console.ReadLine());

            Console.Write("Zu wie viel Prozent soll ein Baum anfangen zu wachsen: ");
            int treeGrow = int.Parse(Console.ReadLine());

            Console.Write("Wie hoch soll der Wald sein: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Wie breit soll der Wald sein: ");
            int width = int.Parse(Console.ReadLine());

            Console.Clear();

            // Initialize the forest
            string[,] forest = InitializeForest(width, height);

            // Simulation loop
            while (true)
            {
                Render(forest, width, height);

                // Simulate fire, growth, etc.
                forest = CatchFire(forest, width, height, treeBurn);
                forest = FireSpread(forest, width, height);
                forest = FireExtinguish(forest, width, height);
                forest = TreeGrow(forest, width, height, treeGrow);

                Thread.Sleep(500); // Pause for visibility
            }
        }

        static string[,] InitializeForest(int width, int height)
        {
            Random random = new Random();
            string[,] forest = new string[height, width];
            string[] allowed = new string[] { "🌳", "🪨", "🟤" };

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int index = random.Next(allowed.Length);
                    forest[i, j] = allowed[index];
                }
            }
            return forest;
        }

        static string[,] CatchFire(string[,] forest, int width, int height, int z)
        {
            Random random = new Random();
            string[,] forestClone = (string[,])forest.Clone();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int probability = random.Next(1, 101);
                    if (probability <= z && (forest[i, j] == "🌳" || forest[i, j] == "🌱"))
                        forestClone[i, j] = "🔥";
                }
            }
            return forestClone;
        }

        static void Render(string[,] forest, int width, int height)
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(forest[i, j]);
                }
                Console.Write("\n");
            }
        }

        static string[,] FireSpread(string[,] forest, int width, int height)
        {
            string[,] forestClone = (string[,])forest.Clone();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (forest[i, j] == "🌳" && HasFireNeighbor(forest, i, j, width, height))
                        forestClone[i, j] = "🔥";
                }
            }
            return forestClone;
        }

        static bool HasFireNeighbor(string[,] forest, int i, int j, int width, int height)
        {
            for (int y = -1; y <= 1; y++)
            {
                for (int x = -1; x <= 1; x++)
                {
                    if (y == 0 && x == 0) continue;
                    int ny = i + y, nx = j + x;
                    if (ny >= 0 && ny < height && nx >= 0 && nx < width && forest[ny, nx] == "🔥")
                        return true;
                }
            }
            return false;
        }

        static string[,] FireExtinguish(string[,] forest, int width, int height)
        {
            string[,] forestClone = (string[,])forest.Clone();
            Random random = new Random();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (forest[i, j] == "🔥")
                    {
                        // Nach dem Feuer: zufällig entscheiden, ob es zu Erde (♨️) oder Steinen (🪨) wird
                        int probability = random.Next(1, 101);
                        if (probability <= 50) // 50% Chance für Erde, 50% für Steine
                            forestClone[i, j] = "♨️";
                        else
                            forestClone[i, j] = "🪨";
                    }
                    else if (forest[i, j] == "♨️")
                    {
                        // Verglühungen (♨️) werden zu Erde (🟤)
                        forestClone[i, j] = "🟤";
                    }
                }
            }
            return forestClone;
        }

        static bool HasTreeNeighbor(string[,] forest, int i, int j, int width, int height)
        {
            for (int y = -1; y <= 1; y++)
            {
                for (int x = -1; x <= 1; x++)
                {
                    if (y == 0 && x == 0) continue;
                    int ny = i + y, nx = j + x;
                    if (ny >= 0 && ny < height && nx >= 0 && nx < width && (forest[ny, nx] == "🌳" || forest[ny, nx] == "🌱"))
                        return true;
                }
            }
            return false;
        }

        static string[,] TreeGrow(string[,] forest, int width, int height, int w)
        {
            string[,] forestClone = (string[,])forest.Clone();
            Random random = new Random();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (forest[i, j] == "🟤")
                    {
                        int probability = random.Next(1, 101);
                        if (probability <= w)
                            forestClone[i, j] = "🌱";
                    }
                    else if (forest[i, j] == "🌱")
                    {
                        int probability = random.Next(1, 101);
                        if (probability < 50)
                            forestClone[i, j] = "🌳";
                    }
                }
            }
            return forestClone;
        }
    }
}
