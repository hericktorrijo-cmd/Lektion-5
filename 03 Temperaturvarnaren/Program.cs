Console.Write("Skriv in temperaturen: ");
if(double.TryParse(Console.ReadLine(), out double temperature))
{
    if(temperature < 0.0)
    {
        Console.WriteLine("Det är minusgrader ute.");
    }
    else
    {
        Console.WriteLine("Det är plusgrader eller nollgradigt.");
    }
}
else
{
    Console.WriteLine("Ogiltig temperatur. Vänligen ange ett giltigt tal.");
}

Console.WriteLine("\n\nTryck på valfri tangent för att fortsätta...");
Console.ReadKey();