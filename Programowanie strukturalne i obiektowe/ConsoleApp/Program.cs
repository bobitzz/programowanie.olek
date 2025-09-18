Console.WriteLine("Ile wygenerować losowań?");
int losowanie = int.Parse(Console.ReadLine());
Console.WriteLine("Zestaw wylosowanych liczb:");
Random random = new Random();

for(int i = 1; i <= losowanie; i++)
{
    Console.WriteLine("Losowanie " + i + ":");
    for(int j = 0; j < 6; j++)
        Console.Write(random.Next(1, 49) + ", ");
}