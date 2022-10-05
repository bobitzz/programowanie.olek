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
	Stos - obszar pami�ci ram przydzielony naszem programowi.
	Obszar ten jest ograniczony i nie da si� go zwi�kszy� w czsie
	dzia�ania programu. L�duj� tam zmienna lokalne.
	*/

	//ta zmienna wyl�duje na stosie
	//deklaracja zmiennej o nazwie 'numer' TYPU int
	int number;
	number = 77;
	cout << number;

	//deklaracja zmiennej  lokalnej o nazwie 'wsk' kt�ra jest wksa�nikiem NA TYP int
	int* wsk;
	/*
	operator 'new' rezerwuje nowy obszar na stercie o wielko�ci typu int
	*/
	wsk = new int;
	*wsk = 7;
	//wy�wietlenie adresu pod jakim znajduje si� obszar na stercie
	cout << wsk << "\n";
	cout << *wsk << "\n";

	//wyswietli 14
	cout << *wsk * 2;
}