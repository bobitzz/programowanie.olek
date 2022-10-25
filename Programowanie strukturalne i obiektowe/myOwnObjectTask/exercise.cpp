/*
zadanie
napisa� klas� (oraz kod testuj�cy) opisuj�cy osob�.
* doda� 5 p�l opisuj�cych osob�(ma by� rok urodzenia).
* dodanie konstruktor�w umo�liwiaj�cych utworzenie
  obiektu na par� sposob�w
* metoda kt�ra wy�wietli informacje o osobie
* metoda kt�ra wy�wietli czy osoba jest pe�noletnia czy nie

*/

#include <iostream>
#include <ctime>

using namespace std;

struct Information
{
	string name, surname, gender, city;
	int yearOfBirthday;
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

	void moreThan18()
	{
		bool adult;
		if ((currentTime() - Personality.yearOfBirthday) > 18)
			adult = true;
		else
			adult = false;

		cout << " Adult: ";
		if (adult == 1)
			cout << "yes" << "\n";
		else if (adult == 0)
			cout << "no" << "\n";
		cout << "\n";
	}

	#pragma region Konstruktory
	Person(string name, string surname, string gender, string city, int yearOfBirthday)
	{
		this->Personality.name = name;
		this->Personality.surname = surname;
		this->Personality.gender = gender;
		this->Personality.city = city;
		this->Personality.yearOfBirthday = yearOfBirthday;
	}

	Person(string name, string surname, string gender, string city)
	{
		this->Personality.name = name;
		this->Personality.surname = surname;
		this->Personality.gender = gender;
		this->Personality.city = city;
		this->Personality.yearOfBirthday = currentTime();
	}
	#pragma endregion

	void ShowInfo()
	{
		cout << "****************\n";
		cout << "Name: " << Personality.name << '\n';
		cout << "Surname: " << Personality.surname << '\n';
		cout << "Gender: " << Personality.gender << '\n';
		cout << "City: " << Personality.city << '\n';
		cout << "Year of birthday: " << Personality.yearOfBirthday << '\n';
		cout << "Age: " << (currentTime() - Personality.yearOfBirthday) << '\n';
		cout << "****************\n";
	}

private:
	Information Personality;
};

int main()
{
	setlocale(LC_CTYPE, "polish");

	Person person1("Marek", "W�jcik", "M�czyzna", "Krak�w", 1997);
	Person person2("Karolina", "Nowak", "Kobieta", "Wroc�aw");

	person1.ShowInfo();
	person1.moreThan18();

	person2.ShowInfo();
	person2.moreThan18();
}