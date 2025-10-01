using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bitte geben Sie Ihr Geburtsdatum im Format TT.MM.JJJJ ein:");
        Console.WriteLine(" ");
        string input = Console.ReadLine();

        if (DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
        {
            DateTime today = DateTime.Today;
            
            if (birthDate > today)
            {
                Console.WriteLine("Ungültiges Datum: Das Geburtsdatum darf nicht in der Zukunft liegen.");
                return;
            }
            
            int years = today.Year - birthDate.Year;
            if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
            {
                years--; 
            }

            int months = (today.Year - birthDate.Year) * 12 + (today.Month - birthDate.Month);
            if (today.Day < birthDate.Day)
            {
                months--;
            }

            int days = (today - birthDate).Days;
            int weeks = days / 7;

            Console.WriteLine("Alter in Jahren: "+ years);
            Console.WriteLine("Alter in Monaten: " + months);
            Console.WriteLine("Alter in Wochen: " + weeks);
            Console.WriteLine("Alter in Tagen: " + days);
        }
        else
        {
            Console.WriteLine("Ungültiges Datum: Bitte geben Sie das Datum im Format TT.MM.JJJJ ein.");
        }
    }
}