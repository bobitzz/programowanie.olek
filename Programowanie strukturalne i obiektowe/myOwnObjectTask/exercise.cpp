/*
zadanie
napisaæ klasê (oraz kod testuj¹cy) opisuj¹cy osobê.
* dodaæ 5 pól opisuj¹cych osobê(ma byæ rok urodzenia).
* dodanie konstruktorów umo¿liwiaj¹cych utworzenie
  obiektu na parê sposobów
* metoda która wyœwietli informacje o osobie
* metoda która wyœwietli czy osoba jest pe³noletnia czy nie

*/

#include <iostream>
#include <ctime>

using namespace std;

struct Information
{
	string name, surname, gender, city;
	int yearOfBirthday, age, moreThan18;
};

class Person
{
public:
	int currentTime()
	{
		time_t now = time(0);
		tm* ltm = new tm;
		localtime_s(ltm, &now);
		return 1900 + ltm->tm_year;
	}

	Person(string name, string surname, string gender, string city, int yearOfBirthday)
	{
		this->Personality.name = name;
		this->Personality.surname = surname;
		this->Personality.gender = gender;
		this->Personality.city = city;
		this->Personality.yearOfBirthday = yearOfBirthday;
	}

	void ShowInfo()
	{
		cout << "****************\n";
		cout << "name: " << Personality.name << '\n';
		cout << "surname: " << Personality.surname << '\n';
		cout << "gender: " << Personality.gender << '\n';
		cout << "city: " << Personality.city << '\n';
		cout << "year of birthday: " << Personality.yearOfBirthday << '\n';
		cout << "age: " << (currentTime() - Personality.yearOfBirthday) << '\n';
		//cout << "more than eighteen: " << moreThan18 << '\n';
		cout << "****************\n";
	}

	int moreThan18()
	{
		if ((currentTime() - Personality.yearOfBirthday) > 18)
			cout << "yes";
		else
			cout << "no";
	}

private:
	Information Personality;
};

int main()
{
	setlocale(LC_CTYPE, "polish");



	Person person1("Marek", "Wójcik", "Mê¿czyzna", "Kraków", 1998);
	person1.ShowInfo();
}