using FractionConsoleApp;
using System.Runtime.CompilerServices;

#region first fraction
Fraction firstFraction = new Fraction();
firstFraction.Numerator = 5;
firstFraction.Denominator = 8;

Console.WriteLine("wartość pierwszego ułamka: " + firstFraction);
#endregion

#region second fraction
Fraction secondFraction = new Fraction(4, 7);

Console.WriteLine("Wartość drugiego ułamka: " + secondFraction);
#endregion

#region third fraction
Fraction thirdFraction = new Fraction();        //iloczym 1 i 2 ułamka
/*
thirdFraction.Numerator = firstFraction.Numerator * secondFraction.Numerator;
thirdFraction.Denominator = firstFraction.Denominator * secondFraction.Denominator;
*/
thirdFraction = firstFraction * secondFraction;

Console.WriteLine("Wartość trzeciego ułamka jest równa: " + thirdFraction);
#endregion