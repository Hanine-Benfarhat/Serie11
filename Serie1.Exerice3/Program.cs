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
