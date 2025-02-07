Console.Write("Entrez un nombre : ");
int lenght = int.Parse(Console.ReadLine());
Console.WriteLine("Carre");
for (int i = 0; i < lenght; i++)
{
    for (int j = 0; j < lenght; j++)
    {
        Console.Write("*");
    }
}
Console.WriteLine("\nTriangle");
for (int i = 1; i <= lenght; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
}
