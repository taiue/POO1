namespace Exercicio_1
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorToatalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return $"nome: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}, Total: {ValorToatalEmEstoque()}";
        }
    }
}
