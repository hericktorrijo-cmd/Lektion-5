Console.Write("Skriv in en siffra mellan 1 och 7 för att få motsvarande veckodag: ");
if(int.TryParse(Console.ReadLine(), out int dayNumber))
{
    switch (dayNumber)
    {
        case 1:
            Console.WriteLine($"Du valde {dayNumber}, vilket motsvarar måndag.");
            break;
        case 2:
            Console.WriteLine($"Du valde {dayNumber}, vilket motsvarar tisdag.");
            break;
        case 3:
            Console.WriteLine($"Du valde {dayNumber}, vilket motsvarar onsdag.");
            break;
        case 4:
            Console.WriteLine($"Du valde {dayNumber}, vilket motsvarar torsdag.");
            break;
        case 5:
            Console.WriteLine($"Du valde {dayNumber}, vilket motsvarar fredag.");
            break;
        case 6:
            Console.WriteLine($"Du valde {dayNumber}, vilket motsvarar lördag.");
            break;
        case 7:
            Console.WriteLine($"Du valde {dayNumber}, vilket motsvarar söndag.");
            break;
        default:
            Console.WriteLine("Ogiltigt val. Vänligen ange en siffra mellan 1 och 7.");
            break;
    }


}
else
{
    Console.WriteLine("ERROR: Ogiltig inmatning. Vänligen ange ett giltigt heltal mellan 1 och 7.");
}

Console.WriteLine("\n\nTryck på valfri tangent för att fortsätta...");
Console.ReadKey();