// See https://aka.ms/new-console-template for more information
using Exercicio_fixacao;

Console.WriteLine("Hello, World!");


Console.Write("Qual a cotação do dolar? ");
double dolar = double.Parse(Console.ReadLine());

Console.Write("Quantos dolares voce vai comprar? ");
double quantidade = double.Parse(Console.ReadLine());

double resultado = ConversorDeMoeda.Converter(dolar, quantidade);
Console.WriteLine("Valor a ser pago: " + resultado.ToString("F2"));

Console.Write("Quantos dolares voce vai comprar? ");
