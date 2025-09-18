# klasa-2c-2022-2023

Console.WriteLine("Ile wygenerować losowań?");
if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
{
    Console.WriteLine("niepoprawna lizcba.");
    return;
}
var zestawy = Generuj(n);
WyswietlZestawy(zestawy);
Wystapienia(zestawy);

List<int[]> Generuj(int n)
{
    var zestawy = new List<int[]>();
    Random random = new Random();

    for (int i = 0; i < n; i++)
    {
        var liczby = Enumerable.Range(1, 49).OrderBy(_ => random.Next()).Take(6).OrderBy(x => x).ToArray();
        zestawy.Add(liczby);
    }
    return zestawy;
}

void WyswietlZestawy(List<int[]> zestawy)
{
    Console.WriteLine("Zestawy wylosowanych luczb:");
    for (int i = 0; i < zestawy.Count; i++)
        Console.WriteLine("Losowanie " + (i + 1) + ": " + (string.Join(" ", zestawy[i])));
}

void Wystapienia(List<int[]> zestawy)
{
    var wystapienia = new int[50];

    foreach (var zestaw in zestawy)
    {
        foreach (var liczba in zestaw)
            wystapienia[liczba]++;
    }

    for (int i = 1; i <= 49; i++)
        Console.WriteLine("Wystapienia liczby " + i + ": " + wystapienia[i]);
}
