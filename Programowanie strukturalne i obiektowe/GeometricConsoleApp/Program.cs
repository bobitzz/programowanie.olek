﻿using GeometricConsoleApp;

Point p = new Point();
//p.x = 5;
//p.y = 8;
p.SetX(5);
p.Y = 8;
p.Display();
Console.WriteLine("Odległość od punktu (0,0) wynosi " + p.DistanceFromCenter);
//p.DistanceFromCenter = 5; //niepoprawna ponieważ brak w propertisie SET

Point p2 = new Point();
//p2.x = 68;
p2.SetX(68);
//p2.y = 78;
p2.Y = 78;
p2.Display();