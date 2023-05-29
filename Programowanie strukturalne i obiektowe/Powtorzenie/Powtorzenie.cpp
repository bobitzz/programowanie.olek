#include <iostream>

void showMenu()
{
	system("cls");
	std::cout << "Menu:\n";
	std::cout << "1. Pole kwadratu\n";
	std::cout << "2. Pole trojkata\n";
	std::cout << "3. Zadanie 1\n";
	std::cout << "4. Zadanie 2\n";
	std::cout << "5. Zadanie 3\n";
	std::cout << "6. Zadanie 4\n";
	std::cout << "7. Zamiana na system binarny\n";
	std::cout << "8. Zamiana na system 2-16\n";
	std::cout << "9. Wydawanie reszty\n";

	std::cout << "0. Zamknij program\n";
}

int chooseOptionFromUser()
{
	std::cout << "Wybierz opcje\n";
	int selectedOption;
	std::cin >> selectedOption;
	return selectedOption;
}

void SquareArea()
{
	std::cout << "Podaj wartosc boku kwadratu:\n";
	int side;
	std::cin >> side;
	int area = side * side;
	std::cout << "Pole kwadratu to " << area << "\n";
}

void TriangleArea()
{
	std::cout << "Podaj wartosc podstawy trojkata:\n";
	int base;
	std::cin >> base;
	std::cout << "Podaj wartosc wysokosci trojkata:\n";
	int height;
	std::cin >> height;
	int area = base * height / 2;
	std::cout << "Pole trojkata to " << area << "\n";
}

void Zadanie1()
{
	std::cout << "Podaj liczbe:\n";
	int number;

	std::cin >> number;

	if (number % 2 == 0)
		number--;

	while (number > 0)
	{
		std::cout << number << ", ";
		number = number - 2;
	}
	std::cout << '\n';
}

void Zadanie2()
{
	std::cout << "Podaj liczbe liczb ci¹gu Fibonacciego:\n";
	int number;
	std::cin >> number;

	int currentFibonacciNumber = 0;
	int prevOneFibonacciNumber = 0;
	int prevTwoFibonacciNumber = 1;

	for (int i = 0; i < number; i++)
	{
		currentFibonacciNumber = prevOneFibonacciNumber + prevTwoFibonacciNumber;
		std::cout << currentFibonacciNumber << ", ";

		prevTwoFibonacciNumber = prevOneFibonacciNumber;
		prevOneFibonacciNumber = currentFibonacciNumber;
	}
	std::cout << '\n';
}

void Zadanie3()
{
	std::cout << "Podaj liczbe:\n";
	int number;
	std::cin >> number;

	for (int i = 1; i <= number; i++)
	{
		if (number % i == 0)
			std::cout << i << ", ";
	}
	std::cout << '\n';

	//wersja 2
	for (int i = 1; i <= sqrt(number); i++)
	{
		if (number % i == 0)
		{
			std::cout << i << ", ";
			int divider = number / i;
			if (divider != i)
				std::cout << divider << ", ";
		}
	}
	std::cout << '\n';

	//wersja 3
	int changeNumber;
	if (number % 2 == 0)
		changeNumber = 1;
	else
		changeNumber = 2;
	for (int i = 1; i <= sqrt(number); i = i + changeNumber)
	{
		if (number % i == 0)
		{
			std::cout << i << ", ";
			int divider = number / i;
			if (divider != i)
				std::cout << divider << ", ";
		}
	}
	std::cout << '\n';
}

void Zadanie4()
{
	std::cout << "Podaj liczbe:\n";
	int numberFromUser;
	std::cin >> numberFromUser;

	std::string arrayOfWordsNumbers[10] = { "zero", "jeden", "dwa", "trzy",
											"cztery", "piec", "szesc",
											"sieden", "osiem", "dziewiec" };
	//arrayOfWordsNumbers[0] = "zero";
	//arrayOfWordsNumbers[1] = "jeden";

	int number = numberFromUser;
	do
	{
		int digit = number % 10;
		number = number / 10;

		std::cout << arrayOfWordsNumbers[digit] << " ";

	} while (number != 0);
	std::cout << "\n";

	number = numberFromUser;
	std::string stringNumber = "";

	do
	{
		int digit = number % 10;
		number = number / 10;

		stringNumber = arrayOfWordsNumbers[digit] + " " + stringNumber;

	} while (number != 0);

	std::cout << stringNumber;
	std::cout << "\n";
}

void DecToBin()
{
	std::cout << "Podaj liczbe w systemie dziesietnym:\n";
	int decNumber;
	std::cin >> decNumber;

	std::string binNumber = "";
	int tmpDecNumber = decNumber;
	while (tmpDecNumber != 0)
	{
		int divisionRest = tmpDecNumber % 2;
		tmpDecNumber = tmpDecNumber / 2;
		binNumber = (char)(divisionRest + 48) + binNumber;
	}

	if (binNumber == "")
		binNumber = "0";

	std::cout << "Liczba w systemie dziesietnym\t" << decNumber << "\n";
	std::cout << "Liczba w systemie binarnym\t" << binNumber << "\n";
}

void DecToAnySystem()
{
	std::cout << "Podaj liczbe w systemie dziesietnym:\n";
	int decNumber;
	std::cin >> decNumber;

	std::cout << "Podaj system docelowy (2-16):\n";
	int targetSystem;
	std::cin >> targetSystem;

	if (targetSystem < 2 || targetSystem > 16)
	{
		std::cout << "Podales zly system\n";
		return;
	}

	char divisionRestsInChar[16] = { '0', '1', '2', '3', '4', '5','6','7','8','9','A', 'B', 'C', 'D', 'E', 'F' };

	std::string targetSystemNumber = "";
	int tmpDecNumber = decNumber;
	while (tmpDecNumber != 0)
	{
		int divisionRest = tmpDecNumber % targetSystem;
		tmpDecNumber = tmpDecNumber / targetSystem;
		targetSystemNumber = divisionRestsInChar[divisionRest] + targetSystemNumber;
	}

	if (targetSystemNumber == "")
		targetSystemNumber = "0";

	std::cout << "Liczba w systemie dziesietnym\t" << decNumber << "\n";
	std::cout << "Liczba w systemie " << targetSystem << "\t" << targetSystemNumber << "\n";
}

void GivingTheRest()
{
	std::cout << "Podaj kwote do wydania:\n";
	float amount;
	std::cin >> amount;

	const int count = 17;
	float tableOfDenominations[count] = {1000, 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.50, 0.25, 0.20, 0.10, 0.05, 0.02, 0.01 };
	int countOfDenominations[count];

	for (int i = 0; i < count; i++)
		countOfDenominations[i] = 0;

	int actDenomination = 0;

	float tmpAmount = amount;
	while (tmpAmount > 0)
	{
		if (tmpAmount >= tableOfDenominations[actDenomination])
		{
			countOfDenominations[actDenomination]++;
			//tmpAmount = tmpAmount - tableOfDenominations[actDenomination];
			tmpAmount -= tableOfDenominations[actDenomination];
		}
		else
			actDenomination++;
	}

	std::cout << "Kwota do wydania: " << amount << "\n";
	for (int i = 0; i < count; i++)
	{
		std::cout << "Nominal " << tableOfDenominations[i] << " x " << countOfDenominations[i] << "\n";
	}
}

void doSelectedTask(int& selectedOption)
{
	switch (selectedOption)
	{
	case 1:
		SquareArea();
		break;
	case 2:
		TriangleArea();
		break;
	case 3:
		Zadanie1();
		break;
	case 4:
		Zadanie2();
		break;
	case 5:
		Zadanie3();
		break;
	case 6:
		Zadanie4();
		break;
	case 7:
		DecToBin();
		break;
	case 8:
		DecToAnySystem();
		break;
	case 9:
		GivingTheRest();
		break;
	case 0:
		return;
	default:
		std::cout << "Brak opcji w menu\n";
		break;
	}

	system("pause");
	/*
	if (selectedOption == 1)
	{
		SquareArea();
	}
	else if (selectedOption == 2)
	{
		TriangleArea();
	}
	else
	//if (selectedOption != 1 && selectedOption != 2)
	{
		std::cout << "Brak opcji w menu\n";
	}*/

}

void mainProgram()
{
	int selected;
	do
	{
		//1. wyœwietlenie menu
		showMenu();

		//2. wybranie opcji przez u¿ytkownika
		selected = chooseOptionFromUser();

		//3. Wykonanie wybranego zadania
		doSelectedTask(selected);

	} while (selected != 0);
}

void main()
{
	mainProgram();
}

