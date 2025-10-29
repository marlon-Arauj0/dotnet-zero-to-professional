using System.Runtime.CompilerServices;
using estudosDotnetParte2.Models;

namespace estudosDotnet.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);

        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);

        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            return Alunos.Count;
        }

        public void ListarAluno()
        {
            if(Alunos.Count == 1)
                {
                    Console.WriteLine($"Aluno do curso de: {Nome}");
                } else
                {
                    Console.WriteLine($"Alunos do curso de: {Nome}");
                }
            for (int count = 0; count < Alunos.Count; count++)
            {

                Console.WriteLine($"N°{count + 1} - {Alunos[count].NomeCompleto}");
            }
            
        }
    }
}