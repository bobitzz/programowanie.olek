#include <iostream>

using namespace std;

void showMenu()
{
    system("cls");
    cout << "Menu: \n";
    cout << "1. Pole kwadratu \n";
    cout << "2. Pole trojkata \n";
}

void chooseOptionFromUser()
{
    cout << "Wybierz opcje: \n";
    int selectOption;
    cin >> selectOption;
}

void doSelectedTask()
{
    if(selectOption == 1)
}

void mainProgram()
{
    //1. wyświetlenie menu
    showMenu();

    //2. wybranie opcji przez użytkownika
    chooseOptionFromUser();

    //3. wykonanie wybranego zadania
    doSelectedTask();
}

int main()
{
    mainProgram();
    
    //cout << "Hello World!\n";
}