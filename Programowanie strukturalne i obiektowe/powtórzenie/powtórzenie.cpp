#include <iostream>

using namespace std;

void showMenu()
{
	system("cls");
	cout << "Menu: \n";
	cout << "1. Pole kwadratu \n";
	cout << "2. Pole trojkata \n";
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

void doSelectedTask(int selectedOption)
{
	if (selectedOption == 1)
	{
		SquareArea();
	}
	if (selectedOption == 2)
	{
		TriangleArea();
	}

}

void mainProgram()
{
	//1. wyświetlenie menu
	showMenu();

	//2. wybranie opcji przez użytkownika
	int selected = chooseOptionFromUser();

	//3. wykonanie wybranego zadania
	doSelectedTask(selected);
}

int main()
{
	mainProgram();

	//cout << "Hello World!\n";
}