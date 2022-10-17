#include <iostream>

using namespace std;

struct CordinateGPS
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
        directionX = 1;
        directionY = 0;
    }

    Car(string name, int x, int y)
    {
        this->name = name;
        cordinateGPS.x = x;
        cordinateGPS.y = y;
        directionX = 1;
        directionY = 0;
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
        cordinateGPS.x += directionX;
        cordinateGPS.y += directionY;
    }

protected:

private:
    string name;

    CordinateGPS cordinateGPS;

    int directionX, directionY;
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