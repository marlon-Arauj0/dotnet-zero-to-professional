using estudosDotnet.models;
class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "Marlon";
        pessoa.Idade = 30;
        pessoa.Apresentar();
    }
}
