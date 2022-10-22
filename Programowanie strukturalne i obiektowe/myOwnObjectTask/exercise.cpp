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

int yearNow()
{
	time_t now = time(0);
	tm* ltm = new tm;
	localtime_s(ltm, &now);
	return 1900 + ltm->tm_year;
}

struct Information
{
	string name, surname, gender, city;
	int yearOfBirthday = yearNow();
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

	int moreThan18(bool adult)
	{
		if ((currentTime() - Personality.yearOfBirthday) > 18)
			adult = true;
		else
			adult = false;

		/*
			if (adult == 1)
				cout << "yes";
			else if (adult == 0)
				cout << "no";
		*/

		return adult;
	}

	Person(string name, string surname, string gender, string city, int yearOfBirthday)
	{
		this->Personality.name = name;
		this->Personality.surname = surname;
		this->Personality.gender = gender;
		this->Personality.city = city;
		this->Personality.yearOfBirthday = yearOfBirthday;
	}

	void ShowInfo(bool adult)
	{
		cout << "****************\n";
		cout << "Name: " << Personality.name << '\n';
		cout << "Surname: " << Personality.surname << '\n';
		cout << "Gender: " << Personality.gender << '\n';
		cout << "City: " << Personality.city << '\n';
		cout << "Year of birthday: " << Personality.yearOfBirthday << '\n';
		cout << "Age: " << (currentTime() - Personality.yearOfBirthday) << '\n';
		cout << "Adult: " << moreThan18(adult);
		if (moreThan18(adult) == 1)
			cout << ". Yes" << '\n';
		else if (moreThan18(adult) == 0)
			cout << ". No" << '\n';
		cout << "****************\n";
	}

private:
	Information Personality;
};

int main(bool adult)
{
	setlocale(LC_CTYPE, "polish");

	Person person1("Marek", "Wójcik", "Mê¿czyzna", "Kraków", 1997);
	person1.ShowInfo(adult);
}