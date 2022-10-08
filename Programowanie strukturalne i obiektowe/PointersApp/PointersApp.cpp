#include <iostream>

using namespace std;

int globalVariable = 7;

void AnotherFunction(int parametr)
{
	parametr = 12;
	int anotherLocalVariableInFunction = 6;
	globalVariable = 8;
}

void TestFunction()
{
	int localVariableInFunction = 5;
	AnotherFunction(localVariableInFunction);
	globalVariable = 45;
}

int main()
{
	/*
	int localvariableInMain = 8;
	TestFunction();
	globalVariable = 77;
	AnotherFunction(7);
	*/
	
	/*
	Stos - obszar pamiêci ram przydzielony naszem programowi.
	Obszar ten jest ograniczony i nie da siê go zwiêkszyæ w czsie
	dzia³ania programu. L¹duj¹ tam zmienna lokalne.
	*/

	//ta zmienna wyl¹duje na stosie
	//deklaracja zmiennej o nazwie 'numer' TYPU int
	int number;
	number = 77;
	cout << number;

	//pozosta³y wolny obszar pamiêci ram

	//deklaracja zmiennej  lokalnej o nazwie 'wsk' która jest wksaŸnikiem NA TYP int. Zmienna ta nie jest typu int
	int* wsk;
	/*
	operator 'new' rezerwuje nowy obszar na stercie o wielkoœci typu int
	i zwraca adres tego obszaru. Adres ten jest zapisywany do zmiennej lokalnej 'wsk'
	*/
	wsk = new int;
	//zapisanie wartoœci 7 do obszaru pod adresem zapisanym we wskaŸniku 'wsk'
	*wsk = 7;
	//wyœwietlenie adresu pod jakim znajduje siê obszar na stercie
	cout << wsk << "\n";
	//wyœwietlanie zawartoœci obszaru pod adresem wskaŸnika 'wsk'
	cout << *wsk << "\n";

	//wyswietli 14
	cout << *wsk * 2;
	//zwalniamy obszar ze sterty
	delete wsk;
	wsk = NULL;

	//*wsk = 55;
	//std::cout << *wsk << "\n";

	cout << "***********************************************\n";

	short tab[3];

	tab[0] = 5;
	*(tab + 0) = 5;

	tab[1] = 15;
	*(tab + 1) = 15;

	tab[2] = 15;
	*(tab + 2) = 15;

	cout << "Adres zerowego elementu tablicy \t" << tab << "\n";
	cout << "Adres pierwszego elementu tablicy \t" << tab + 3 << "\n";

	cout << "***********************************************\n";

	int tab2[7];
	const int rozmiar = 5;
	//int tab3[number];
	int tab4[rozmiar];

	int* tab5 = new int[number];
	tab5[7] = 15;
	*(tab5 + 7) = 15;

	delete tab5;

	tab5 = new int[number];

	delete tab5;

}