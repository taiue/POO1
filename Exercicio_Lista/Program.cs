using Exercicio_Lista;

List<Funcionario> funcionarios = new List<Funcionario>();

Console.WriteLine("Quantos funcionarios serão registrados?: ");
int quantidadeFuncionarios = int.Parse(Console.ReadLine());

for (int i = 0; i < quantidadeFuncionarios; i++)
{
    Console.Write("Digite o nome do funcionario: ");
    string nome = Console.ReadLine();
    Console.Write("Digite o salario do funcionario: ");
    int salario = int.Parse(Console.ReadLine());
    funcionarios.Add(new Funcionario(nome, salario));
}

foreach (var funcionario in funcionarios)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine(funcionario.ToString());
}

Console.WriteLine("Insira o Id do funcionario que recebera aumento");
int id = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a porcentagem do aumento");
double porcentagem = double.Parse(Console.ReadLine());

foreach (var funcionario in funcionarios)
{
    if (funcionario.Id == id)
        funcionario.AumentaSalario(porcentagem);
    else
        Console.WriteLine("Id não existe!");
}

foreach (var funcionario in funcionarios)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine(funcionario.ToString());
}

