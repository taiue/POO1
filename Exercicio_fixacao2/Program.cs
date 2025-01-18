// See https://aka.ms/new-console-template for more information
using Exercicio_fixacao2;

Console.Write("Entre o numero da conta: ");

int numeroConta = int.Parse(Console.ReadLine());

Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();

Console.WriteLine("Havera deposito inicial S/N");
string existeDepositoInicial = Console.ReadLine();

DadosBancarios dados = new DadosBancarios(numeroConta, titular);


if (existeDepositoInicial == "S")
{
    Console.Write("Entre o valor do deposito inicial: ");
    double valorDepositoInicial = double.Parse(Console.ReadLine());
    dados.DepositarValor(valorDepositoInicial);
}

Console.WriteLine(dados.ToString());

Console.WriteLine("Deposite um valor na conta");
double valorDeposito = double.Parse(Console.ReadLine());
dados.DepositarValor(valorDeposito);
Console.WriteLine(dados.ToString());


Console.WriteLine("Saque um valor da conta");
double valorSaque = double.Parse(Console.ReadLine());
dados.SaqueValor(valorSaque);
Console.WriteLine(dados.ToString());



