#include <iostream>
#include <cmath>

using namespace std;

struct Point
{
	int x;
	int y;
};

double calculateDistance(int a, int b)
{
	double distance = sqrt(a * a + b * b);
	return distance;
}

double calculateDistance(Point p)
{
	double distance = sqrt(p.x * p.x + p.y * p.y);
	return distance;
}

void CoordinateTestVersion1()
{
	int x, y;

	//Point point;
	cout << "Podaj x:\n";
	cin >> x;

	cout << "Podaj y:\n";
	cin >> y;

	double distance = calculateDistance(x, y);
	//distance = sqrt(x * x + y * y);

	cout << "Odleglosc od zera wynosi: " << distance << '\n';
}

void CoordinateTestVersion2()
{
	Point userPoint;
	cout << "Podaj x:\n";
	cin >> userPoint.x;

	cout << "Podaj y:\n";
	cin >> userPoint.y;

	double distance = calculateDistance(userPoint.x, userPoint.y);
	//distance = sqrt(x * x + y * y);

	cout << "Odleglosc od zera wynosi: " << distance << '\n';
}

int main()
{
	//CoordinateTestVersion1();
	CoordinateTestVersion2();
}

string name;
string surname;
int age;
int height;
//w strukturze mo¿e byæ inna struktura
struct pearson
{
	string name;
	string surname;
	int age;
	int height;
	Point coordinate;
};

pearson p1;
//p1.name
//p1.coordinate.x = 5;

string nameTab[5];
string surnameTab[5];
int ageTab[5];
int hightTab[5];

pearson pTab[5];
//pTab[1].name = "Ala";