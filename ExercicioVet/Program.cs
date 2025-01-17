using ExercicioVet;

Console.WriteLine("Quantos quartos serão alugados? ");
Rent[] rent = new Rent[10];

int n = int.Parse(Console.ReadLine());


for (int i = 0; i < n; i++)
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Numero do Quarto: ");
    int quarto = int.Parse(Console.ReadLine());
    rent[quarto] = new Rent { Nome = nome, Email = email};
}

Console.WriteLine("Quartos ocupados");
for (int i = 0; i < 10; i++)
{
    if (rent[i] != null)
        Console.WriteLine("Quarto: " + i +"\n"+ rent[i].ToString());
}
