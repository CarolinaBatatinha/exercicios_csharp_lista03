// 46.	Repita o exercício anterior considerando que os menus sejam de uma lanchonete, e são os seguintes:
// -	As bebidas e as quantidades vendidas
// -	Os lanches e as quantidades vendidas
// -	As porções e as quantidades consumidas

// No final do processamento (no final do cálculo de todas as contas das mesas) as seguintes informações devem ser impressas:
// a.	A maior e a menor conta
// b.	A média de gasto por mesa
// c.	A média de gasto por pessoa
// d.	A média de lanches consumidos por mesa
// e.	A média de lanches consumidos por pessoas
// f.	A média de porções consumidas por mesa
// g.	O total de lanche e de porções

using System;

class Program
{
    static void Main(string[] args)
    {
        double valorBebida = 2.50;
        double valorLanche = 5.00;
        double valorPorcao = 8.00;

        double maiorConta = 0;
        double menorConta = double.MaxValue;
        double somaContas = 0;
        int totalMesas = 0;
        int totalPessoas = 0;
        int totalLanches = 0;
        int totalPorcoes = 0;

        Console.WriteLine("Calculadora de contas da lanchonete");
        Console.WriteLine("-----------------------------------");

        string continuar = "S";
        while (continuar.ToUpper() == "S")
        {
            Console.WriteLine("Mesa #{0}", totalMesas + 1);

            Console.Write("Quantidade de bebidas: ");
            int quantidadeBebidas = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de lanches: ");
            int quantidadeLanches = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de porções: ");
            int quantidadePorcoes = int.Parse(Console.ReadLine());

            double totalConta = (quantidadeBebidas * valorBebida) +
                                (quantidadeLanches * valorLanche) +
                                (quantidadePorcoes * valorPorcao);

            if (totalConta > maiorConta)
            {
                maiorConta = totalConta;
            }

            if (totalConta < menorConta)
            {
                menorConta = totalConta;
            }

            somaContas += totalConta;
            totalMesas++;
            totalPessoas++; // Considerando 1 pessoa por mesa
            totalLanches += quantidadeLanches;
            totalPorcoes += quantidadePorcoes;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Total da mesa: R$ {0:F2}", totalConta);
            Console.WriteLine("-----------------------------------");

            Console.Write("Deseja calcular a conta de outra mesa? (S/N): ");
            continuar = Console.ReadLine();
        }

        double mediaGastoMesa = somaContas / totalMesas;
        double mediaGastoPessoa = somaContas / totalPessoas;
        double mediaLanchesMesa = (double)totalLanches / totalMesas;
        double mediaLanchesPessoa = (double)totalLanches / totalPessoas;
        double mediaPorcoesMesa = (double)totalPorcoes / totalMesas;

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Resumo das contas");
        Console.WriteLine("Maior conta: R$ {0:F2}", maiorConta);
        Console.WriteLine("Menor conta: R$ {0:F2}", menorConta);
        Console.WriteLine("Média de gasto por mesa: R$ {0:F2}", mediaGastoMesa);
        Console.WriteLine("Média de gasto por pessoa: R$ {0:F2}", mediaGastoPessoa);
        Console.WriteLine("Média de lanches consumidos por mesa: {0:F2}", mediaLanchesMesa);
        Console.WriteLine("Média de lanches consumidos por pessoa: {0:F2}", mediaLanchesPessoa);
        Console.WriteLine("Média de porções consumidas por mesa: {0:F2}", mediaPorcoesMesa);
        Console.WriteLine("Total de lanches: {0}", totalLanches);
        Console.WriteLine("Total de porções: {0}", totalPorcoes);
        Console.WriteLine("-----------------------------------");
    }
}
