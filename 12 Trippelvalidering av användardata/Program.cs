Console.Write("Vänligen skriv in ett heltal: ");

if(int.TryParse(Console.ReadLine(), out int number))
{
    if(number == 0)
    {
        Console.WriteLine($"Heltalet du skrev är {number}");
    }
    else if(number > 0)
    {
        Console.WriteLine("Talet är positivt");
        
        if(number % 2 == 0)
        {
            Console.WriteLine("Det är ett jämnt tal");
        }
        else
        {
            Console.WriteLine("Det är ett ojämnt tal"); 
        }

    }

    else
    {
        Console.WriteLine("Talet är negativt");

        if(number % 2 == 0)
        {
            Console.WriteLine("Det är ett negativt jämnt-tal");
        }
        else
        {
            Console.WriteLine("Det är ett negativt ojämnt-tal");
        }

    }
}
else
{
    Console.WriteLine("Ogiltigt tal!");
}

Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen");
Console.ReadKey();