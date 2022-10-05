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

	//deklaracja zmiennej  lokalnej o nazwie 'wsk' która jest wksaŸnikiem NA TYP int
	int* wsk;
	/*
	operator 'new' rezerwuje nowy obszar na stercie o wielkoœci typu int
	*/
	wsk = new int;
	*wsk = 7;
	//wyœwietlenie adresu pod jakim znajduje siê obszar na stercie
	cout << wsk << "\n";
	cout << *wsk << "\n";

	//wyswietli 14
	cout << *wsk * 2;
}