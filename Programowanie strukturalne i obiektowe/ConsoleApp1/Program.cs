using System.Security.Cryptography;

Console.WriteLine("Ile wygenerować losowań?");
int losowanie = int.Parse(Console.ReadLine());
Console.WriteLine("Zestaw wylosowanych liczb:");
Random random = new Random();

int[] wystapienia = new int[50];

for (int i = 0; i < losowanie; i++)
{
    Console.Write("\nLosowanie " + i + ": ");
    for (int j = 0; j < 6; j++)
    {
        int liczba = random.Next(1, 49);
        wystapienia[liczba]++;
        Console.Write(liczba + (j == 5 ? "" : ", "));
    }
    Console.WriteLine();
}

for (int i = 1; i <= 49; i++)
{
    Console.WriteLine($"Wystąpienia liczby {i}: {wystapienia[i]}");
}

/*
 * brakuje funkcji do losowania(nie mzoe byc zliczania w tej funkcji);
 * powt;
 */