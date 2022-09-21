Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Geben sie den Umsatz des Kunden ein:");
double Umsatz = Convert.ToDouble(Console.ReadLine());

if (Umsatz > 500)
{
    Console.WriteLine("Dem Kunden wurden 10% Rabatt gewährt. Der Rechnungsbetrag beträgt: " + (Umsatz * 0.9));
}
else if (Umsatz > 100 & Umsatz <= 500)
{
    Console.WriteLine("Dem Kunden wurden 5% Rabatt gewährt. Der Rechnungsbetrag beträgt: " + (Umsatz * 0.95));
}
else if (Umsatz <= 0) {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ERROR: Der Umsatz ist eine Minus Zahl!");
}
else
{
    Console.WriteLine("Dem Kunden wurden keine Rabatte gewährt. Der Rechnungsbetrag beträgt immernoch: " + Umsatz);
}