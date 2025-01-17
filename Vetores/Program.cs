//int n = int.Parse(Console.ReadLine());

//double[] vect = new double[n];

//for (int i = 0; i < n; i++)
//{
//    vect[i] = double.Parse(Console.ReadLine());
//}


//double sum = 0.0;

//for (int i = 0; i < n; i++)
//{
//    sum += vect[i];
//}

//double avr = sum / n;

//Console.WriteLine(avr.ToString());

using Vetores;

int n = int.Parse(Console.ReadLine());

Produto[] produto = new Produto[n];    

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Digite nome produto " + i);
    string nome = Console.ReadLine();
    Console.WriteLine("Digite o preco produto " + i);
    double preco = double.Parse(Console.ReadLine());

    produto[i] = new Produto { Name = nome, Price = preco };
}

double sum = 0.0;
for (int i = 0; i < n; i++)
{
    sum += produto[i].Price;
}

double avr = sum / n;

Console.WriteLine("preço medio = " + avr.ToString("F2"));