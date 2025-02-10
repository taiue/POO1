namespace Exercicio_Lista
{
    internal class Funcionario
    {
        Random rnd = new Random();
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            Id = rnd.Next(1, 10);
            Nome = nome;
            Salario = salario;
        }

        public double AumentaSalario(double porcentagem)
        {
            double aumento = (porcentagem / 100) * Salario;
            return Salario += aumento;
        }
  
    
        public override string ToString()
        {
            return $"Id: {Id} \n" +
                   $"Nome: {Nome}\n" +
                   $"Salario: {Salario}";
        }

    }
}
