
/*
Zadanie
Napisa� klas� (oraz kod testuj�cy) opisuj�c� osob�. 
* Doda� 5 p�l opisuj�cych osob� (ma by� rok urodzenia).
* dodanie konstruktor�w umo�liwiaj�cych utworzenie
  obiektu na par� sposob�w
* metoda kt�ra wy�wietli informacje o osobie
* metoda kt�ra wy�wietli czy osoba jest pe�noletnia czy nie
* 
*/

#include <iostream>
#include <ctime>
int main()
{
    time_t now = time(0);

    std::cout << "Number of second since January 1,1970 is:: " 
        << now << std::endl;

    tm* localTimeStructTm = new tm;
    localtime_s(localTimeStructTm , &now);

    // print various components of tm structure.
    std::cout << "Year:" << 1900 + localTimeStructTm->tm_year << std::endl;
    std::cout << "Month: " << 1 + localTimeStructTm->tm_mon << std::endl;
    std::cout << "Day: " << localTimeStructTm->tm_mday << std::endl;
    std::cout << "Time: ";
    std::cout << localTimeStructTm->tm_hour << ":";
    std::cout << localTimeStructTm->tm_min << ":";
    std::cout << localTimeStructTm->tm_sec << std::endl;
    delete localTimeStructTm;
}

