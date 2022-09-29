#include <iostream>
#include <cmath>

using namespace std;

double calculateDistance(int a, int b)
{
    return sqrt(a * a + b * b);
}

void CoordinateTestVersion1()
{
    int x, y;

    cout << "Podaj x:\n";
    cin >> x;

    cout << "Podaj y:\n";
    cin >> y;

    double distance=calculateDistance(x, y);
    //distance = sqrt(x * x + y * y);

    cout << "Odleglosc od zera wynosi: " << distance << '\n';
}

int main()
{
    CoordinateTestVersion1();
}
