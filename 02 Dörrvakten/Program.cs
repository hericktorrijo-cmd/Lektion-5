Console.Write("Skriv in din ålder: ");

if (int.TryParse(Console.ReadLine(), out int age))
{
    if (age < 18)
    {
        Console.WriteLine("Du är under 18 år gammal.");

    }
    else
    {
        Console.WriteLine("Välkommen in!");
    }
}
else
{
    Console.WriteLine("Ogiltig ålder. Vänligen ange ett giltigt heltal.");
}

Console.WriteLine("\n\nTryck på valfri tangent för att fortsätta...");
Console.ReadKey();