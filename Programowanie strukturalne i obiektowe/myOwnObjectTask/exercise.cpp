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



	Person person1("Marek", "W�jcik", "M�czyzna", "Krak�w", 1998);
	person1.ShowInfo();
}