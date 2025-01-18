using Exercicio_1;

Console.WriteLine("Hello, World!");

Produto produto = new Produto();

Console.WriteLine("Entre os dados do produto: ");
Console.Write("Nome: ");
produto.Nome = Console.ReadLine();

Console.Write("Preço: ");
produto.Preco = double.Parse(Console.ReadLine());

Console.Write("Quantidade: ");
produto.Quantidade = int.Parse(Console.ReadLine());


Console.WriteLine($"Dados do produto:" +
    $" {produto.Nome.ToString()}," +
    $" {produto.Preco}," +
    $" {produto.Quantidade} unidades, " +
    $"Total: {produto.ValorToatalEmEstoque()}");

Console.Write("Digite o numero de produtos a ser adicionado: ");
int qte = int.Parse(Console.ReadLine());
produto.AdicionarProduto(qte);
Console.WriteLine("Dados atualizados: " + produto.ToString());


Console.Write("Digite a quantidade de produtos a ser removida: ");
qte = int.Parse(Console.ReadLine());
produto.RemoverProduto(qte);
Console.WriteLine("Dados atualizados: " + produto.ToString());

