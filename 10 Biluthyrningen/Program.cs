Console.Write("Hur gammal är du: ");
int age = int.Parse(Console.ReadLine());

Console.Write("Hur många år har du haft körtkort: ");
int driverLicenseAge = int.Parse(Console.ReadLine());

if (age > 24 &&  driverLicenseAge > 2)
{
    Console.WriteLine($"Du är {age} år gammal och har haft körtkortet i 3 år eller mer! " +
        $"Grattis du får hyra sportbil!");
}
else if (age > 24 && driverLicenseAge < 3 )
{
    Console.WriteLine($"Du är tillräckligt gammal men du har inte haft körtkort" +
        $"tillräckligt länge");
}
else if (age < 25  && driverLicenseAge > 2 )
{
    Console.WriteLine($"Du är inte tillräckligt gammal för att hyra sportbil!");
}
else
{
    Console.WriteLine("Tyvärr får du inte hyra sportbil!");
}

Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen");
Console.ReadLine();
