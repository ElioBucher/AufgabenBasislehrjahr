namespace Aufgabe8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dein Kommentar:");
        Console.WriteLine(" ");
        string input = Console.ReadLine()?.ToLower();

        string[] forbiddenWords =
        {
            "viagra", "sex", "porno", "fick", "schlampe", "arsch", "wixxer", "wixer", "wichser", "hs", "hurensohn",
            "nuttensohn", "nutte", "fotze", "hure", "schwanz", "pimmel", "penis", "vagina", "arschloch", "drecksack",
            "miststück", "scheiße", "scheißkerl", "bitch", "fuck", "motherfucker", "shit", "asshole", "bastard", "cock",
            "cunt", "dick", "pussy", "slut", "whore", "nigger", "kike", "spast", "behindert", "kacke", "schwein", "sau",
            "drecksfotze", "flittchen", "hurenbock", "mutterficker", "neger", "zigeuner", "kanacke", "schwitzbude",
            "scheißhure", "schwitzfotze", "titten", "wichs", "abfucken", "abspritzen", "anal", "arschficker",
            "arschgeige", "arschgesicht", "arschlecker", "brunz", "brutalo", "drecksau", "drecksschwein",
            "fotzenlecker", "fotzenschlecker", "fotzenwichser", "fotzenvoll", "fotzenzerstörer", "fotzenzerficker",
            "fotzenzerlecker", "fotzenzerstampfer", "fotzenzertrümmerer", "fotzenzerfetzer", "geil", "hurenkind",
            "hurensohn", "mutterficker", "nuttensohn", "penner", "pisser", "schlitz", "schlitzauge", "schwanzlutscher",
            "tunte", "wichsfotze", "wichsmaschine", "niga", "neger", "wixxa"
        };

        bool containsForbiddenWord = false;
        int forbiddenWordCount = 0;
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            if (input != null && input.Contains(forbiddenWords[i]))
            {
                containsForbiddenWord = true;
                forbiddenWordCount++;
            }
        }

        if (containsForbiddenWord)
        {
            Console.WriteLine("Dein Kommentar enthält " + forbiddenWordCount + " verbotene Wörter");
            Console.WriteLine("Er wird nicht veröffentlicht...");
        }
        else
        {
            Console.WriteLine("Vielen Dank für deinen Kommentar.");
        }
    }
}