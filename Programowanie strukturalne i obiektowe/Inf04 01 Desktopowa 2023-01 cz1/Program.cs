int a, b;
Console.WriteLine("Podaj a");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj b");
b = int.Parse(Console.ReadLine());

while (a != b)
{
    if (a > b)
        a -= b;
    else
        b -= a;
}

Console.WriteLine("NWD: " + a);