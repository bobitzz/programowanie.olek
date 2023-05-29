
/*
Zadanie
Napisaæ klasê (oraz kod testuj¹cy) opisuj¹c¹ osobê. 
* Dodaæ 5 pól opisuj¹cych osobê (ma byæ rok urodzenia).
* dodanie konstruktorów umo¿liwiaj¹cych utworzenie
  obiektu na parê sposobów
* metoda która wyœwietli informacje o osobie
* metoda która wyœwietli czy osoba jest pe³noletnia czy nie
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

