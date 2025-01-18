using Exerrcicio_2;

internal class Program
{

    private static void Main(string[] args)
    {

        Console.WriteLine("Entre o valor do raio: ");
        double raio = double.Parse(Console.ReadLine());

        double circ = Calculadora.Circunferencia(raio);
        double vol = Calculadora.Volume(raio);

        Console.WriteLine("Circunferencia: " + circ.ToString("F2"));
        Console.WriteLine("Volume: " + vol.ToString("F2"));
        Console.WriteLine("Valor de Pi: " + Calculadora.Pi);
    }


}