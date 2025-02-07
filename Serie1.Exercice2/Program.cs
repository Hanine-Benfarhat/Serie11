Console.Write("Entrez un nombre : ");
int nombre = int.Parse(Console.ReadLine());
if (nombre % 2 == 0)
{
    Console.WriteLine($"Le nombre {nombre} est pair.");
}
else
{
    Console.WriteLine($"Le nombre {nombre} est impair.");
}
