Console.WriteLine("Skriv in en mening/text: ");
string text  = Console.ReadLine().ToLower();

if(string.IsNullOrWhiteSpace(text))
{
    Console.WriteLine("Texten är tom");
}
else if(text.StartsWith("hejsan"))
{
    Console.WriteLine("Texten börjar med hejsan");
}
else if(text.EndsWith("!"))
{
    Console.WriteLine("Texten slutar med utropstecken!");
}
else
{
    Console.WriteLine("Ingen matchning hittades!");
}

Console.WriteLine("\n\nTryck valfri tangent för att stänga konsolen");
Console.ReadKey();