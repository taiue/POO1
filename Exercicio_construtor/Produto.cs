namespace Exercicio_construtor
{
    class Produto
    {
        //Atributo privativo 
        private string _nome;

        //propriedades autoimplementadas
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        //Construtores
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 0;
        }
        public Produto()
        {
            Quantidade = 10;
        }

        //Propriedades customizadas 
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


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
            return $"nome: {_nome}, Preço: {Preco}, Quantidade: {Quantidade}, Total: {ValorToatalEmEstoque()}";
        }
    }
}
