#include <iostream>

int globalVariable = 7;

void AnotherFunction(int parameter)
{
    parameter = 12;
    int anotherLocalVariableInFuntion = 6;
    globalVariable = 8;
}

void TestFunction()
{
    int loacalVariableInFunction = 5;
    AnotherFunction(loacalVariableInFunction);
    globalVariable = 45;
}

int main()
{
    /*int localVariableInMain = 8;
    TestFunction();
    globalVariable = 77;
    AnotherFunction(7);*/

    /*
    Stos - obszar pami�ci RAM przydzielony naszemu programowi.
    Obszar ten jest ograniczony i nie da si� go zwiekszy� w czasie 
    dzia�ania programu. L�duj� tam zmienne lokalne.
    */

    //ta zmienna wyl�duje na stosie
    //deklaracja zmiennej o nazwie 'number' TYPU int
    int number;
    number = 77;
    std::cout << number << '\n';
    number = number + 1;

    //sterta - pozosta�y wolny obszar pami�ci RAM

    /*
    deklaracja zmiennej lokalnej o nazwie 'wsk' kt�ra jest wska�nikiem NA TYP int
    Zmienna ta nie jest typu int.
    */
    int *wsk;
    /*
    Operator 'new' rezerwuje nowy obszar na stercie o wielko�ci typu int 
    i zwraca adres tego obszaru. Adres ten jest zapisywany do zmiennej lokalnej 'wsk'
    */
    wsk = new int;
    //zapisanie warto�ci 7 do obszaru pod adresem zapisanym we wska�niku 'wsk'
    *wsk = 7;
    //wy�wietlenie adresu pod jakim znajduje si� obszar na stercie
    std::cout << wsk << "\n";
    //wy�wietlenie zawarto�ci obszaru pod adresem we wska�niku 'wsk'
    std::cout << *wsk << "\n";

    //number b�dzie r�wny 14
    number = (*wsk) * 2;

    //zwalniamy obszar ze sterty
    delete wsk;
    wsk = NULL;

    //*wsk = 55;
    //std::cout << *wsk << "\n";

    std::cout << "***********************************************\n";

    short tab[3];

    tab[0] = 5;
    *(tab + 0) = 5;

    tab[1] = 15;
    *(tab + 1) = 15;

    tab[2] = 15;
    *(tab + 2) = 15;

    std::cout << "Adres zerowego elementu tablicy \t" << tab << "\n";
    std::cout << "Adres pierwszego elementu tablicy \t" << tab + 3 << "\n";

    std::cout << "***********************************************\n";

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


