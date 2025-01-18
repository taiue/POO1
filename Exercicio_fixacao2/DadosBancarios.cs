namespace Exercicio_fixacao2
{
    internal class DadosBancarios
    {

        public int NumeroConta { get; private set; }
        public string NomeTitular { get; private set; }
        public double SaldoConta { get; private set; }

        public DadosBancarios(int numeroConta, string nomeTitular, double saldoConta)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            SaldoConta = saldoConta;
        }
        public DadosBancarios(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }


        public double DepositarValor(double deposito)
        {
            return SaldoConta = SaldoConta + deposito;
        }

        public double SaqueValor(double saque)
        {
            return SaldoConta = SaldoConta - saque;
        }

        public override string ToString()
        {
            return $"Numero da Conta: {NumeroConta.ToString()}, Titular: {NomeTitular}, Saldo: {SaldoConta.ToString()}";
        }
    }

}
