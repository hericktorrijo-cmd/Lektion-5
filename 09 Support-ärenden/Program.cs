Console.Write("Ange kodfelsnummer: ");

if (int.TryParse(Console.ReadLine(), out int number))
{
    string kategory = number switch
    {
        >= 100 and <= 199 => "Hårdvarufel",
        >= 200 and <= 299 => "Mjukvarufel",
        _ => "Okänt fel"
    };

    Console.WriteLine($"Feltyp: {kategory}");
}
else
{
    Console.WriteLine("ERROR! Vänligen ange en giltid kod!");
}

Console.WriteLine("\n\nTryck på valfri tangent för att fortsätta...");
Console.ReadKey();