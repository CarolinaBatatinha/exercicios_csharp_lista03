// 44.	Faça um algoritmo para calcular a conta das mesas de uma lanchonete com base no consumo de seus clientes. Considere que o usuário pode escolher os seguintes itens do menu:
// 1 – lanches:
//     X-Tudo      		R$ 4,00
//     X-Bacon		    R$ 3,00
//     X-Salada	        R$ 2,00
// 2 – Bebidas:
//     Refrigerante 	R$ 1,50
//     Cerveja     		R$ 1,80
//     Agua Mineral		R$ 0,80

// 	O programa deverá ler as quantidades dos itens e calcular o valor total da conta. Isso será realizado até que o usuário deseja sair do programa. No entanto, é necessário saber no final do processamento do cálculo das mesas, os valores da maior conta, menor conta e a média dos valores das contas das mesas.

using System;

class Program
{
    static void Main(string[] args)
    {
        double valorXTudo = 4.00;
        double valorXBacon = 3.00;
        double valorXSalada = 2.00;

        double valorRefrigerante = 1.50;
        double valorCerveja = 1.80;
        double valorAguaMineral = 0.80;

        double maiorConta = 0;
        double menorConta = double.MaxValue;
        double somaContas = 0;
        int totalMesas = 0;

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Calculadora de contas da lanchonete");
        Console.WriteLine("-----------------------------------");

        string continuar;
        do
        {
            int quantidadeXTudo, quantidadeXBacon, quantidadeXSalada;
            int quantidadeRefrigerante, quantidadeCerveja, quantidadeAguaMineral;

            Console.WriteLine("Informe as quantidades dos itens consumidos pela mesa:");

            Console.Write("X-Tudo: ");
            quantidadeXTudo = Convert.ToInt32(Console.ReadLine());

            Console.Write("X-Bacon: ");
            quantidadeXBacon = Convert.ToInt32(Console.ReadLine());

            Console.Write("X-Salada: ");
            quantidadeXSalada = Convert.ToInt32(Console.ReadLine());

            Console.Write("Refrigerante: ");
            quantidadeRefrigerante = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cerveja: ");
            quantidadeCerveja = Convert.ToInt32(Console.ReadLine());

            Console.Write("Agua Mineral: ");
            quantidadeAguaMineral = Convert.ToInt32(Console.ReadLine());

            double totalConta = (quantidadeXTudo * valorXTudo) +
                                (quantidadeXBacon * valorXBacon) +
                                (quantidadeXSalada * valorXSalada) +
                                (quantidadeRefrigerante * valorRefrigerante) +
                                (quantidadeCerveja * valorCerveja) +
                                (quantidadeAguaMineral * valorAguaMineral);

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

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Total da mesa: R$ {0:F2}", totalConta);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Deseja calcular a conta de outra mesa? (S/N)");
            continuar = Console.ReadLine();
        } while (continuar.ToUpper() == "S");

        double mediaContas = somaContas / totalMesas;

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("RESUMO DAS CONTAS");
        Console.WriteLine("Maior conta: R$ {0:F2}", maiorConta);
        Console.WriteLine("Menor conta: R$ {0:F2}", menorConta);
        Console.WriteLine("Média das contas: R$ {0:F2}", mediaContas);
        Console.WriteLine("-----------------------------------");
    }
}
