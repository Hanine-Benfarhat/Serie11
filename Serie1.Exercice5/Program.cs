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
