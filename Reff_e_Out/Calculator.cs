namespace Reff_e_Out
{
    internal class Calculator
    {
        public static void Triple(ref int x) //modificador de parametro ref, faz com que o parametro seja uma Referencia para a variavel original
        {
            x = x * 3;
        }


        public static void Triple2(int origem, out int result) // parecido mas diferente 
        {
            result = origem * 3;
        }


        // nao é recomendado uso de ambos
    }
}
