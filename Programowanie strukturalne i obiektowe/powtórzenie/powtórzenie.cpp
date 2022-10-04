#include <iostream>
#include <stdlib.h>
#include <string>

using namespace std;

void showMenu()
{
	system("cls");
	cout << "Menu: \n";
	cout << "1. Pole kwadratu \n";
	cout << "2. Pole trojkata \n";
	cout << "3. Liczby nieparzyste do 1 \n";
	cout << "4. Ciag Fibonacciego \n";
	cout << "5. Dzielnik podanej liczby \n";
	cout << "6. Liczba na wyraz \n";
	cout << "7. dec na bin \n";
	cout << "8. reszta z zakupów \n";
	cout << "0. Zamknij program \n";
}

int chooseOptionFromUser()
{
	cout << "Wybierz opcje: \n";
	int selectedOption;
	cin >> selectedOption;
	return selectedOption;
}

void SquareArea()
{
	float side, area;
	cout << "podaj dlugosc boku: \n";
	cin >> side;
	area = side * side;
	cout << "pole jest rowne: " << area << '\n';
}

void TriangleArea()
{
	float side, height, area;
	cout << "podaj dlugosc boku: \n";
	cin >> side;
	cout << "Podaj wysokosc: ";
	cin >> height;
	area = (side * height) / 2;
	cout << "pole jest rowne: " << area << '\n';
}

void oddNubmer()
{
	int number;
	cout << "podaj liczbe: \n";
	cin >> number;

	for (int i = number; i >= 1; i--)
	{
		if (i % 2 == 1)
			cout << i << ", ";
	}
	cout << '\n';
}

void stringOfFibonnaciego()
{
	int liczba;
	cout << "Podaj ile chcesz zobaczyc liczb z ciagu Fibonaciego: \n";
	cin >> liczba;

	int fibonaci_1 = 0, fibonaci_2 = 1;
	for (int i = 0; i < liczba; i++)
	{
		cout << fibonaci_2 << ", ";
		fibonaci_2 += fibonaci_1;
		fibonaci_1 = fibonaci_2 - fibonaci_1;
	}
}

void divisorOfNumber()
{
	int number;
	cout << "podaj liczbe: \n";
	cin >> number;

	for (int i = 1; i <= number; i++)
	{
		if (number % i == 0)
			cout << i << ", ";
	}
	cout << '\n';
}

void numberForWord()
{
	cout << "Podaj liczbe:\n";
	int numberFromUser;
	cin >> numberFromUser;

	std::string arrayOfWordsNumbers[10] = { "zero", "jeden", "dwa", "trzy",
											"cztery", "piec", "szesc",
											"sieden", "osiem", "dziewiec" };

	int number = numberFromUser;
	do
	{
		int digit = number % 10;
		number = number / 10;

		cout << arrayOfWordsNumbers[digit] << " ";

	} while (number != 0);
	cout << "\n";

	number = numberFromUser;
	string stringNumber = "";

	do
	{
		int digit = number % 10;
		number = number / 10;

		stringNumber = arrayOfWordsNumbers[digit] + " " + stringNumber;

	} while (number != 0);

	cout << stringNumber;
	cout << "\n";
}

void decimalToBinary()
{
	int liczba;
	cout << "Podaj liczbe: \n";
	cin >> liczba;

	int i = 31;
	bool ok = false;
	while (i--)
	{
		if (liczba >> i & 1 & !ok)
			ok = true;

		if (ok)
			cout << ((liczba >> i) & 1);

	}
	cout << '\n';
}

void decToOtherSystem()
{
	cout << "podaj liczbe(2-16): \n";
	int liczba;
	cin >> liczba;


}

void remnant()
{

}

void doSelectedTask(int selectedOption)
{
	switch (selectedOption)
	{
	case 0:
		return;
	case 1:
		SquareArea();
		break;
	case 2:
		TriangleArea();
		break;
	case 3:
		oddNubmer();
		break;
	case 4:
		stringOfFibonnaciego();
		break;
	case 5:
		divisorOfNumber();
		break;
	case 6:
		numberForWord();
		break;
	case 7:
		decimalToBinary();
		break;
	case 8:
		remnant();
		break;
	default:
		cout << "brak opcji w menu \n";
		break;
	}

	system("pause");

	/*	if (selectedOption == 1)
		{
			SquareArea();
		}
		if (selectedOption == 2)
		{
			TriangleArea();
		}
	*/
}

void mainProgram()
{
	int selected;
	do {
		//1. wyświetlenie menu
		showMenu();

		//2. wybranie opcji przez użytkownika
		selected = chooseOptionFromUser();

		//3. wykonanie wybranego zadania
		doSelectedTask(selected);

		//napisz funkcje, która wczyta liczbe od użytkownika i wyświetli wszystkie liczby nieparzyste od tej liczby do 1
		oddNubmer();

		//napisz program który wyświetli kolejną liczbę ciągu Fibonnaciego, ilość liczb wczytaj z klawiatury
		stringOfFibonnaciego();

		//napisz program który wyświwtli wszystkie dzilniki danej liczby
		divisorOfNumber();

		//napisz funkcje, która wczyta od użytkownika liczbe i wyświetli słownie poszczególne cyfry tej liczby
		numberForWord();

		//zamień liczbe w systemie decymalnym na binarny
		decimalToBinary();

		//pobierz od uzytkownika kwote i wydaj mureszte z zakupow w największych nominałach
		remnant();

	} while (selected != 0);
	if (selected = 0)
		exit;
}

int main()
{
	mainProgram();

	//cout << "Hello World!\n";
}