namespace Aufgabe12;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------");
        Console.WriteLine("Zahlen Aufsummieren");
        Console.WriteLine("-------------------");

        Console.WriteLine("Geben Sie die zu summierenden Ganzzahlen mit Komma getrennt ein:");


        int[] zahlen = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
        int[] result = SumUp(zahlen);

        Console.WriteLine("Ergebnis: " + string.Join(", ", result));

        static int[] SumUp(int[] arr)
        {
            int[] result = new int[arr.Length];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
                result[i] = sum += arr[i];


            return result;
        }
    }
}