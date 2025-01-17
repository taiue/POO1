namespace ExercicioVet
{
    internal class Rent
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} \n" +
                   $"Email: {Email} \n";
        }

    }
}
