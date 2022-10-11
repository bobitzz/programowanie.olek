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
    }

    Car(string name, int x, int y)
    {
        this->name = name;
        cordinateGPS.x = x;
        cordinateGPS.y = y;
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

    }

protected:

private:
    string name;

    CordinateGPS cordinateGPS;
};

int main()
{
    setlocale(LC_CTYPE, "polish");

    Car carFirst("Super bryka");
    Car carSecond("Lodówa", 10, 10);

    carFirst.ShowInfo();
    carSecond.ShowInfo();
}