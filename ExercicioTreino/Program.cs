using ExercicioTreino;
using System.Globalization;

Triangulo x, y;

x = new Triangulo();
y = new Triangulo();


Console.WriteLine("Entre com as medidas do triangulo X:");

x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triangulo Y:");

y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.Area();

double areaY = y.Area();


Console.WriteLine($"Area de X = {areaX} e area de Y = {areaY}");


if (areaX == areaY)
{
    Console.WriteLine("Areas de mesmo tamanho");
}
else if (areaX > areaY)
{
    Console.WriteLine("Maior area é do triangulo X");
}
else
{
    Console.WriteLine("Maior area é do triangulo Y");
}