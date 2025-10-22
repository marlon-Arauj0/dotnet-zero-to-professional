namespace estudosDotnetParte2.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;

        public string Nome
        {
            get => _nome; /*body expressions*/

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser null");
                }
                _nome = value;
            }
        }
        
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade tem que ser maior que 0");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}