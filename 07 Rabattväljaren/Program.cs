Console.Write("Är du student? (ja/nej): ");
string input = Console.ReadLine()?.Trim().ToLower();

Console.Write("Har du ett Mecenat-kort? (ja/nej): ");
string mecenatInput = Console.ReadLine()?.Trim().ToLower();

if(input == "ja" && mecenatInput == "ja")
{
    Console.WriteLine("Du får 20% rabatt!");
}
else if (input == "ja" && mecenatInput == "nej")
{
    Console.WriteLine("Du får 10% rabatt!");
}
else
{
    Console.WriteLine("Tyvärr, du betalar standardpris.");
}

Console.WriteLine("\n\nTryck på valfri tangent för att fortsätta...");
Console.ReadKey();
