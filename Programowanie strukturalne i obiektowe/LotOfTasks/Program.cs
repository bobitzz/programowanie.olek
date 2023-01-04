using System;

/*
Podstawy programowania:
1. Program obliczający średnią arytmetyczną dwóch liczb.
2. Program obliczający pole prostokąta.
3. Program obliczający objętość stożka.
4. Program obliczający pole koła.
5. Program obliczający wartość wyrażenia a^2 + b^2
6. Program obliczający pole trójkąta o podstawie b i wysokości h
7. Program obliczający objętość kuli o promieniu r
8. Program obliczający pole trapezu o podstawach a i b oraz wysokości h
9. Program obliczający średnią ważoną trzech liczb z podanymi odpowiednimi wagami w1, w2 i w3.
Instrukcja If:
1. Program sprawdzający czy podana liczba jest parzysta czy nieparzysta
2. Program sprawdzający czy podana liczba jest dodatnia, ujemna czy równa zero
3. Program sprawdzający czy podany rok jest rokiem przestępnym
4. Program wyświetlający odpowiedni komunikat w zależności od podanej oceny (np. "bardzo dobry" dla oceny 5, "dobry" dla oceny 4 itd.)
5. Program sprawdzający czy podane hasło jest poprawne (np. jeśli hasło jest "abc123", program powinien wyświetlić "hasło poprawne", jeśli jest inne, powinien wyświetlić "hasło niepoprawne").
6.Program sprawdzający czy podana data jest poprawna (np. sprawdzając, czy dzień jest z zakresu od 1 do 31, miesiąc od 1 do 12 itd.)
7. Program wyświetlający odpowiedni komunikat w zależności od podanej temperatury (np. "ciepło" dla temperatury powyżej 20 stopni Celsjusza, "chłodno" dla temperatury poniżej 10 stopni Celsjusza itd.)
Pętle:
1. Program sprawdzający czy podana liczba jest liczbą pierwszą (czyli taką, która dzieli się tylko przez 1 i przez siebie samą)
2. Program sprawdzający czy podany ciąg znaków jest palindromem (czyli takim, który czytany od tyłu jest taki sam, jak czytany od przodu, np. "kajak")
3. Program sprawdzający czy podane dwa słowa są anagramami (czyli takimi, które zawierają te same litery, ale w innym układzie, np. "klasa" i "salka")
4. Program sprawdzający czy podana liczba jest liczbą doskonałą (czyli taką, której suma dzielników (z wyłączeniem samej siebie) jest równa danej liczbie, np. 6 jest liczbą doskonałą, ponieważ 1 + 2 + 3 = 6).
Pętla for:
1. Program wyświetlający na ekranie kolejne liczby naturalne od 1 do 10
2. Program obliczający sumę liczb od 1 do 100
3. Program wyświetlający na ekranie kwadraty liczb od 1 do 10 (np. 1, 4, 9, 16 itd.)
4. Program wyświetlający na ekranie silnie z liczb od 1 do 10 (np. 1!, 2!, 3!, 4! itd.)
5. Program wyświetlający na ekranie tabliczkę mnożenia od 1 do 9 (np. 1x1=1, 1x2=2, 1x3=3 itd.).
6. Program wyświetlający na ekranie wszystkie liczby podzielne przez 3 z zakresu od 1 do 100
7.Program obliczający sumę kwadratów liczb od 1 do 10
8. Program wyświetlający na ekranie ciąg Fibonacciego do 20 elementu (ciąg Fibonacciego to ciąg gdzie każdy element jest sumą dwóch poprzednich, np. 0, 1, 1, 2, 3, 5, 8, 13 itd.)
9. Program wyświetlający na ekranie kolejne potęgi 2 od 2^0 do 2^10 (np. 2^0, 2^1, 2^2 itd.)
10. Program wyświetlający na ekranie kolejne elementy ciągu a_n = a_{n-1} + a_{n-2}, gdzie a_0=1, a_1=1 (ciąg ten zaczyna się od 1, 1, 2, 3, 5, 8, 13 itd.).
Pętla do-while:
1. Program pytający użytkownika o hasło i wyświetlający komunikat "hasło poprawne" lub "hasło niepoprawne" dopóki użytkownik nie poda poprawnego hasła (np. "abc123").
2. Program wyświetlający na ekranie kwadraty liczb od 1 do 10 (np. 1, 4, 9, 16 itd.) dopóki suma tych kwadratów nie przekroczy 1000.
Trudniejsze zadania:
1. Program implementujący algorytm szyfrowania Cezara (proste szyfrowanie, w którym każdy znak w tekście jest zastępowany innym znakiem, przesuniętym o stałą liczbę pozycji w alfabecie).
2. Program obliczający największy wspólny dzielnik (NWD) dwóch liczb
3. Program obliczający najmniejszą wspólną wielokrotność (NWW) dwóch liczb.
4. Program wyciągający informacje z numeru PESEL
5. Napisz program, który pobiera od użytkownika ciąg znaków i wyświetla liczbę samogłosek i spółgłosek w tym ciągu.
Dla zaawansowanych:
1. Program implementujący algorytm generowania liczb pseudolosowych (np. algorytm Mersenne Twister).
2. Algorytm szyfrowania AtBash Cipher - algorytm szyfrujący, w którym każda litera jest zamieniana na literę z przeciwnej strony alfabetu (np. A na Z, B na Y itd.)
3. Algorytm szyfrowania Morse'a - algorytm szyfrujący, w którym każda litera w tekście jest zamieniana na ciąg znaków "+" i "-", zgodny z kodem Morse'a.
4. Napisz program, który pobiera od użytkownika dwie macierze kwadratowe o takim samym rozmiarze i wyświetla ich iloczyn.
5. Program który na wejściu przyjmie równanie a na wyjściu da równanie w odwrotnej notacji polskiej ONP. Np. na wejściu 2+3*4 na wyjścu da 234*+
6. Program, który na wejściu przyjmie rówanie w ONP a na wyjściu wyświetli wynik rówania.
7. Napisz grę kółko i krzyżyk.
*/

namespace LotOfTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new();
            exercise.Exercise16();

            /*
                Console.WriteLine("Podaj liczbę:");
                string dana =  Console.ReadLine();
                int number = int.Parse(dana);
            */
        }
    }
}
