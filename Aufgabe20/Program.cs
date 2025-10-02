using System.Net;
using Newtonsoft.Json.Linq;

namespace Aufgabe20;

class Program
{
    static void Main(string[] args)
    {
        bool next = true;

        while (next == true)
        {
            WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            string jsonData = new StreamReader(responseStream).ReadToEnd();

            JArray array = JArray.Parse(jsonData);

            String witz = array.First["text"].ToString();

            Console.WriteLine(" ");
            Console.WriteLine(witz);

            Console.Write("Nächsten Witz holen? j/n: ");
            char input = Console.ReadKey().KeyChar;

            if (input == 'n')
            {
                next = false;
            }
            else if (input == 'j')
            {
                next = true;
            }
            else if (input != 'j' && input != 'n')
            {
                Console.WriteLine("Falsche Eingabe...");
                break;
            }
// 
        }
    }
}