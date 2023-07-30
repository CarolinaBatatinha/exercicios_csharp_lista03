// 38.	Uma determinada universidade pretende desenvolver uma pesquisa através dos seus alunos matriculados. Para cada aluno será digitado um dos códigos 1,2 e 3 que significam:
// •	1 indica que o aluno cursa Administração
// •	2 indica que o aluno cursa Administração com gestão em Informática
// •	3 indica que o aluno cursa Sistemas de Informação.

// Deseja-se saber a porcentagem e o número de alunos por curso. Considere um número indeterminado de alunos matriculados.
using System;

class Program
{
    static void Main(string[] args)
    {
        int totalAlunos = 0;
        int alunosAdministracao = 0;
        int alunosAdministracaoInformatica = 0;
        int alunosSistemasInformacao = 0;

        Console.WriteLine(
            "Digite o código do curso do aluno (1 - Administração, 2 - Administração com gestão em Informática, 3 - Sistemas de Informação)"
        );
        Console.WriteLine("Digite 0 para encerrar o programa.");

        int codigoCurso;
        do
        {
            Console.Write("Código do curso do aluno: ");
            codigoCurso = Convert.ToInt32(Console.ReadLine());

            switch (codigoCurso)
            {
                case 1:
                    alunosAdministracao++;
                    break;
                case 2:
                    alunosAdministracaoInformatica++;
                    break;
                case 3:
                    alunosSistemasInformacao++;
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Código inválido. Tente novamente.");
                    continue;
            }

            totalAlunos++;
        } while (codigoCurso != 0);

        double porcentagemAdministracao = (double)alunosAdministracao / totalAlunos * 100;
        double porcentagemAdministracaoInformatica =
            (double)alunosAdministracaoInformatica / totalAlunos * 100;
        double porcentagemSistemasInformacao = (double)alunosSistemasInformacao / totalAlunos * 100;

        Console.WriteLine("===== RESULTADOS =====");
        Console.WriteLine($"Total de alunos: {totalAlunos}");
        Console.WriteLine(
            $"Porcentagem de alunos em Administração: {porcentagemAdministracao}% ({alunosAdministracao})"
        );
        Console.WriteLine(
            $"Porcentagem de alunos em Administração com gestão em Informática: {porcentagemAdministracaoInformatica}% ({alunosAdministracaoInformatica})"
        );
        Console.WriteLine(
            $"Porcentagem de alunos em Sistemas de Informação: {porcentagemSistemasInformacao}% ({alunosSistemasInformacao})"
        );
        Console.ReadLine();
    }
}
