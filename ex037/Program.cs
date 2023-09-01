//37.	Agora repita o exercício anterior para um número indefinido de pessoas.


using System;

class Program
{
    static void Main(string[] args)
    {
        const int totalPessoas = 3;
        float somaSalarioDoisFilhos = 0;
        float somaSalarioSemFilhos = 0;
        float somaSalarioUmFilho = 0;
        float somaSalarioOutros = 0;
        float somaSalarioGeral = 0;
        int contDoisFilhos = 0;
        int contUmFilho = 0;
        int contSemFilhos = 0;

        string opcao;

        do
        {
            Console.Write("Insira seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Insira o valor do seu salário em reais (R$): ");
            float salario = float.Parse(Console.ReadLine());
            Console.Write("Informe quantos filhos você tem: ");
            int qtdeFilhos = int.Parse(Console.ReadLine());

            somaSalarioGeral += salario;

            if (qtdeFilhos == 2)
            {
                contDoisFilhos++;
                somaSalarioDoisFilhos += salario;
            }
            else if (qtdeFilhos == 0)
            {
                contSemFilhos++;
                somaSalarioSemFilhos += salario;
            }
            else if (qtdeFilhos == 1)
            {
                contUmFilho++;
                somaSalarioUmFilho += salario;
            }
            else
            {
                somaSalarioOutros += salario;
            }

            Console.Write("Deseja cadastrar mais pessoas? (S/N)");
            opcao = Console.ReadLine().ToUpper();
            Console.WriteLine();
        } while (opcao == "S");

        float salarioMedioSemFilhos = somaSalarioSemFilhos / contSemFilhos;
        float salarioMedioDoisFilhos = somaSalarioDoisFilhos / contDoisFilhos;
        float salarioMedioUmFilho = somaSalarioUmFilho / contUmFilho;
        float salarioMedioGeral = somaSalarioGeral / totalPessoas;

        Console.WriteLine($"O salário médio das pessoas que têm dois filhos é de R$ {salarioMedioDoisFilhos:F2}.");
        Console.WriteLine($"O salário médio das pessoas que não têm filhos é de R$ {salarioMedioSemFilhos:F2}.");
        Console.WriteLine($"A média salarial maior entre os que têm um e dois filhos é de R$ {Math.Max(salarioMedioUmFilho, salarioMedioDoisFilhos):F2}.");
        Console.WriteLine($"O salário médio geral é de R$ {salarioMedioGeral:F2}.");
    }
}
