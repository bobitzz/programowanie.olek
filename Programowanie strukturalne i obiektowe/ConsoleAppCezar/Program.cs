Console.WriteLine("Podaj tekst");
string text = Console.ReadLine();
Console.WriteLine("Podaj klucz");
int key = int.Parse(Console.ReadLine());
Console.WriteLine(SzyfrCezara(text, key));

static string SzyfrCezara(string text, int key)
{
    string result = "";
    for (int i = 0; i < text.Length; i++)
    {
        char letter = text[i];

        if (letter != 32)
        {
            result += (char)((letter + key) % 256);
        }
        else
        {
            result += (char)(letter % 256);
        }
    }
    return result;
}