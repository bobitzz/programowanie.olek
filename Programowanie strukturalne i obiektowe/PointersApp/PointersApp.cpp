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
    Stos - obszar pamiêci RAM przydzielony naszemu programowi.
    Obszar ten jest ograniczony i nie da siê go zwiekszyæ w czasie 
    dzia³ania programu. L¹duj¹ tam zmienne lokalne.
    */

    //ta zmienna wyl¹duje na stosie
    //deklaracja zmiennej o nazwie 'number' TYPU int
    int number;
    number = 77;
    std::cout << number << '\n';
    number = number + 1;

    //sterta - pozosta³y wolny obszar pamiêci RAM

    /*
    deklaracja zmiennej lokalnej o nazwie 'wsk' która jest wskaŸnikiem NA TYP int
    Zmienna ta nie jest typu int.
    */
    int *wsk;
    /*
    Operator 'new' rezerwuje nowy obszar na stercie o wielkoœci typu int 
    i zwraca adres tego obszaru. Adres ten jest zapisywany do zmiennej lokalnej 'wsk'
    */
    wsk = new int;
    //zapisanie wartoœci 7 do obszaru pod adresem zapisanym we wskaŸniku 'wsk'
    *wsk = 7;
    //wyœwietlenie adresu pod jakim znajduje siê obszar na stercie
    std::cout << wsk << "\n";
    //wyœwietlenie zawartoœci obszaru pod adresem we wskaŸniku 'wsk'
    std::cout << *wsk << "\n";

    //number bêdzie równy 14
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


