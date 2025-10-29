using estudosDotnet.Models;
using estudosDotnetParte2.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Marlon";
p1.Sobrenome = "Silva";

Pessoa p2 = new Pessoa("João", "Luiz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAluno();