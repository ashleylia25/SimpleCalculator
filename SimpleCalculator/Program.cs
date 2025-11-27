Console.Clear();
Console.WriteLine("Napiste prvni cislo, znamenko a druhe cislo:");
String cislo1 = Console.ReadLine();
String znamenko = Console.ReadLine();
String cislo2 = Console.ReadLine();

int prvniCislo = int.Parse(cislo1);
int druheCislo = int.Parse(cislo2);

if (druheCislo == 0 && znamenko == "/")
{
    Console.WriteLine("Nejde delit nulou.");
}
else if (znamenko == "+")
{
    Console.WriteLine(prvniCislo + druheCislo);
}
else if (znamenko == "-")
{
    Console.WriteLine(prvniCislo - druheCislo);
}
else if (znamenko == "*")
{
    Console.WriteLine(prvniCislo * druheCislo);
}
else if (znamenko == "/")
{
    Console.WriteLine(prvniCislo / druheCislo);
}
else
{
    Console.WriteLine("Nelze");
}

