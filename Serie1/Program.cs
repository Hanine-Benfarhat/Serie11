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

//exercice3
List<int> nombres = new List<int> { 5, 96, -12, 1442, 0, 8, -123, 0, 55, -55, 0, 9, 5, 19, 18, -12, 66, 20, 4456, 1, 32, -4, 0, 8, 3, 53 };
Console.WriteLine("Liste avant suppression:");
for (int i = 0; i < nombres.Count; i++)
{
    Console.Write($"{nombres[i]} ");
}
for (int i = nombres.Count - 1; i >= 0; i--)
{
    if (nombres[i] < 0)
    {
        nombres.RemoveAt(i);
    }
}
Console.WriteLine("\nListe après suppression :");
for (int i = 0; i < nombres.Count; i++)
{
    Console.Write(nombres[i] + " ");
}
Console.WriteLine();

//exercice4
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
List<string> etudiants = new List<string>();
int id = 1;
while (true)
{
    Console.Write("Entrez le nom ou QUITTER pour quitter)");
    string nom = Console.ReadLine();
    if (nom.ToLower() == "quitter")
    {
        break;
    }
    if (!string.IsNullOrEmpty(nom))
    {
        string nomUnique = nom + id;
        etudiants.Add(nomUnique);
        Console.WriteLine("\nListe des étudiants :");
        for (int i = 0; i < etudiants.Count; i++)
        {
            Console.WriteLine($"Etudiant {etudiants[i]} – classement {i + 1}");
        }
        id++;
    }
    else
    {
        Console.WriteLine("Veuillez entrer un nom non Null");
    }
}
