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
