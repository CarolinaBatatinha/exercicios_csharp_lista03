// 35.	Escrever um algoritmo que um número indefinido de valores, para cada entrada de dados a entrada de 2 valores, o primeiro representando o número de um aluno, e o segundo representando a sua altura em centímetros. Encontre o aluno mais alto e o mais baixo. Mostre o número do aluno mais alto e do mais baixo, junto com suas alturas. 

using System;

class Program
{
    static void Main(string[] args)
    {
        int alunoMaisAlto = 0;
        int alunoMaisBaixo = 0;
        int alturaMaisAlta = 0;
        int alturaMaisBaixa = int.MaxValue;

        while (true)
        {
            Console.Write("Digite o número do aluno (ou 0 para encerrar): ");
            int numeroAluno = Convert.ToInt32(Console.ReadLine());

            if (numeroAluno == 0)
                break;

            Console.Write("Digite a altura do aluno em centímetros: ");
            int altura = Convert.ToInt32(Console.ReadLine());

            if (altura > alturaMaisAlta)
            {
                alturaMaisAlta = altura;
                alunoMaisAlto = numeroAluno;
            }

            if (altura < alturaMaisBaixa)
            {
                alturaMaisBaixa = altura;
                alunoMaisBaixo = numeroAluno;
            }
        }

        Console.WriteLine("\n## Aluno mais baixo ##");
        Console.WriteLine($"Número do aluno: {alunoMaisBaixo}");
        Console.WriteLine($"Altura: {alturaMaisBaixa}cm");
        Console.WriteLine("==============================");
        Console.WriteLine("\n## Aluno mais alto ##");
        Console.WriteLine($"Número do aluno: {alunoMaisAlto}" );
        Console.WriteLine($"Altura: {alturaMaisAlta}cm");
    }
}
