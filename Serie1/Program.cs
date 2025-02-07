//exercice1
Console.WriteLine("Entrez le nom");
string prenom = Console.ReadLine();
Console.WriteLine("Entrez le prenom");
string nom = Console.ReadLine();
Console.WriteLine("Entrez l'age");
int age = int.Parse(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine($"{prenom} {nom} est majeur.");
}
else
{
    Console.WriteLine($"{prenom} {nom} est mineur.");
}

//exercice2

//exercice3

//exercice4

//exercice5
Console.WriteLine("Entrez un nombre :");
int a = int.Parse(Console.ReadLine());
int x = 0, y = 1, z;
for (int i = 0; i < a; i++)
{
    z = x + y;
    Console.Write($"{z} ");
    x = y;
    y = z;
}

//exercice6
