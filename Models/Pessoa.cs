namespace estudosDotnetParte2.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }


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

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}";
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
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}