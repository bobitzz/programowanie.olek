#include <iostream>

using namespace std;

struct CordinateGPS
{
	int x, y;
};

struct Direction
{
	int x, y;
};

class Car
{
public:
	Car(string name)
	{
		this->name = name;
		cordinateGPS.x = 0;
		cordinateGPS.y = 0;
		direction.x = 1;
		direction.y = 0;
	}

	Car(string name, int x, int y)
	{
		this->name = name;
		cordinateGPS.x = x;
		cordinateGPS.y = y;
		direction.x = 1;
		direction.y = 0;
	}

	void ShowInfo()
	{
		cout << "**************************\n";
		cout << "Samochód o nazwie " << name << "\n";
		cout << "Pozycja (" << cordinateGPS.x << ";" << cordinateGPS.y << ")\n";
		cout << "**************************\n";
	}

	void moveForward()
	{
		cordinateGPS.x += direction.x;
		cordinateGPS.y += direction.y;
	}

	void turnLeft()
	{
		/*
				if (direction.x == 1 && direction.y == 0)
		{
			direction.x = 0;
			direction.y = 1;
		}
		else if (direction.x == 0 && direction.y == 1)
		{
			direction.x = -1;
			direction.y = 0;
		}
		else if (direction.x == -1 && direction.y == 0)
		{
			direction.x = 0;
			direction.y = -1;
		}
		else if (direction.x == 0 && direction.y == -1)
		{
			direction.x = 1;
			direction.y = 0;
		}
		*/

		int tmX = direction.x;
		direction.x = -direction.y;
		direction.y = tmX;
	}

	void turnRight()
	{
		int tmX = direction.x;
		direction.x = direction.y;
		direction.y = tmX;
	}

protected:

private:
	string name;

	CordinateGPS cordinateGPS;

	Direction direction;
};

int main()
{
	setlocale(LC_CTYPE, "polish");

	Car carFirst("Super bryka");
	Car carSecond("Lodówa", 10, 10);

	carFirst.ShowInfo();
	carSecond.ShowInfo();

	carFirst.moveForward();
	carSecond.moveForward();
}