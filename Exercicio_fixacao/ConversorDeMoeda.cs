using System.Security.Cryptography;

namespace Exercicio_fixacao
{
    internal class ConversorDeMoeda
    {
        public static double IoF = 6.0;
        public static double Converter(double dolar, double quantidade)
        {
            double total = dolar * quantidade;
            return total + total * IoF / 100.0;
        }
    }
}
