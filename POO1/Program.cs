﻿using Inicio;

Console.WriteLine("Hello, World!");


Point p;

p.x = 10;
p.y = 20;

Console.WriteLine(p);

p = new Point();
Console.WriteLine(p);

// nullables 

double? x = null;
double? y = 10.0;

Console.WriteLine(x.GetValueOrDefault());
Console.WriteLine(y.GetValueOrDefault());

Console.WriteLine(x.HasValue);
Console.WriteLine(y.HasValue);

if (x.HasValue)
    Console.WriteLine(x.Value);
else
    Console.WriteLine("X is null");

if (y.HasValue)
    Console.WriteLine(y.Value);
else
    Console.WriteLine("Y is null");

double a = x ?? 5;
double b = y ?? 5;

Console.WriteLine(a + b);