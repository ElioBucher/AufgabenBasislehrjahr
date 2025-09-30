int sum = 0;
int sum2 = 0;
 
Console.WriteLine("Bitte gib eine 2-stellige Ganzzahl ein.");
int zahl = Convert.ToInt32(Console.ReadLine());
 
if (zahl > 99 || zahl < 10)
{
     Console.WriteLine("Braschki gib eine zweistellige Zahl ein... (z.B. 67).");
     Environment.Exit(0);
}
 
Console.WriteLine("Bitte gib eine zweite 2-stellige Ganzzahl ein.");
int zahl2 = Convert.ToInt32(Console.ReadLine());
 
if (zahl2 > 99 || zahl2 < 10)
{
     Console.WriteLine("Braschki gib eine zweistellige Zahl ein... (z.B. 67).");
     Environment.Exit(0);
}
 
Console.WriteLine("");
Console.WriteLine("Zahl 1: " + zahl);
Console.WriteLine("Zahl 2: " + zahl2);
 
Console.WriteLine("-----------------------------------------------");
Console.WriteLine($"| {"Zahl",-7} | {"Quersumme",-11} | {"Zahl / Quersumme",-17}   |");
Console.WriteLine("-----------------------------------------------");

 
int start = Math.Min(zahl, zahl2);
int ende = Math.Max(zahl, zahl2);
 
for (int wert = start; wert <= ende; wert++)
{
     int quersumme = 0;
     int kopie = wert;
     while (kopie != 0)
     {
         quersumme += kopie % 10;
         kopie /= 10;
     }
 
     if (wert % quersumme == 0)
     {
         double div = (double)wert / quersumme;
         Console.WriteLine($"| {wert,-7} | {quersumme,-11} | {div,-17:F0}   |");
     }
}
 
Console.WriteLine("-----------------------------------------------");