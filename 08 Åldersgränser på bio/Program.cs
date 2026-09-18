Console.Write("Ange vilken ålder så skriver vi vilken fimkategori du tillhör: ");

if(int.TryParse(Console.ReadLine(), out int age))
{
    if(age >= 0 && age <= 6)
    {
        Console.WriteLine("Barnfilm");
    }
    else if (age > 7 && age <= 10)
    {
        Console.WriteLine($"Du är {age} år och tillhör Tonårsfilm");
    }
    else if (age > 11 && age <= 14)
    {
        Console.WriteLine($"Du är {age} år och tillhör Ungdomsfilm");
    }
    else if (age >= 15)
    {
        Console.WriteLine($"Du är {age} år och tillhör Vuxenfilm");
    }
    else
    {
        Console.WriteLine("Ogiltig ålder. Vänligen ange ett positivt heltal.");
    }

}

else
{
    Console.WriteLine("ERROR! Vänligen ange en giltig ålder.");
}

Console.WriteLine("\n\nTryck på valfri tangent för att fortsätta...");
Console.ReadKey();