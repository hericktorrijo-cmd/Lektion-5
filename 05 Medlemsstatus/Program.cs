using System.Net.WebSockets;

Console.Write("Vänligen skriv in om du har medlemkort Basic, Standard eller Premium: ");
string membershipType = Console.ReadLine()?.Trim().ToLower();

switch(membershipType)
{
    case "basic":
        Console.WriteLine($"Du har ett {membershipType} medlemkort. Kosar 99 kr/månad.");
        break;
    case "standard":
        Console.WriteLine($"Du har ett {membershipType} medlemkort. Kosar 149 kr/månad.");
        break;
    case "premium":
        Console.WriteLine($"Du har ett {membershipType} medlemkort. Kosar 199 kr/månad.");
        break;
    default:
        Console.WriteLine("ERROR: Ogiltig inmatning. Vänligen ange ett giltigt medlemkort.");
        break;
}

Console.WriteLine("\n\nTryck på valfri tangent för att fortsätta...");
Console.ReadKey();