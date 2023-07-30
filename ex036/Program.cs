// 36.	Faça um algoritmo que leia o nome, salário e número de filhos de 100 pessoas, e calcule:
// •	O salário médio das pessoas que possuam 2 filhos
// •	O salário médio das que não possuem filhos
// •	Qual a média salarial maior, entre os que têm um e dois filhos
// •	O salário médio geral

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

        for (int i = 1; i <= totalPessoas; i++)
        {
            Console.WriteLine("Insira seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira o valor do seu salário em reais (R$): ");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe quantos filhos você tem: ");
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
        }

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
