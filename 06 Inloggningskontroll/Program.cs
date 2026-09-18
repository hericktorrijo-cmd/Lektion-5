Console.Write("Ange användarnamn: ");
string username = Console.ReadLine()?.Trim();
Console.Write("Ange lösenord: ");
string password = Console.ReadLine()?.Trim();

if (username == "admin" && password == "hemligt123")
{
    Console.WriteLine("Inloggning lyckades!");
}
else
{
    Console.WriteLine("Felaktiga uppgifter.");
}

Console.WriteLine("\n\nTryck på valfri tangent för att fortsätta...");
Console.ReadKey();