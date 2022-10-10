#include <iostream>

using namespace std;

class Point
{
public:
	double calculateDistance()
	{
		double distance = sqrt(x * x + y * y);
		return distance;
	}

	void SetX(int x)
	{
		//zak�adamy �e jeste�my tylko w pierwszej �wiartce uk�adu XY
		if (x >= 0)
			this->x = x;
	}

	void SetY(int y)
	{
		//zak�adamy �e jeste�my tylko w pierwszej �wiartce uk�adu XY
		if (y >= 0)
			this->y = x;
	}
protected:

private:
	int x;
	int y;
};

/*
double calculateDistance(Point p)
{
	double distance = sqrt(p.x * p.x + p.y * p.y);
	return distance;
}
*/

int main()
{
	Point point;
	point.SetX(10);
	point.SetY(15);
	double distance = point.calculateDistance();
	cout << "Dystans od punktu (0, 0) = " << distance << "\n";
}

/*
* cout, cin jest klas�, lecz nie mo�na ich zadeklarowa� oraz przypisa� zmiennych
* wy�wietla liczbe binarnie lub innym systemie liczbowym
		cout.setf(ios::binary);
*/