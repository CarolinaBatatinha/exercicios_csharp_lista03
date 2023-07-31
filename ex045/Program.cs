// 45.	Faça um algoritmo para calcular a conta de um número indefinidos de mesas de uma pizzaria. Considere que o usuário possa informar através de um menu os seguintes itens:
// -	As bebidas e as quantidades vendidas
// -	As pizzas e as quantidades vendidas
// -	As sobremesas e as quantidades vendidas

// No final do processamento (no final do cálculo de todas as contas das mesas) as seguintes informações devem ser impressas:
// a.	A maior e a menor conta
// b.	A média de gasto por mesa
// c.	A média de gasto por pessoa
// d.	A média de pizzas consumida por mesa
// e.	A média de pedaços de pizzas consumidas por pessoas
// f.	A média de cervejas consumidas por mesas

using System;

class Program
{
    static void Main(string[] args)
    {
        double valorPizza = 25.00;
        double valorBebida = 5.00;
        double valorSobremesa = 10.00;

        double maiorConta = 0;
        double menorConta = double.MaxValue;
        double somaContas = 0;
        int totalMesas = 0;
        int totalPessoas = 0;
        int totalPizzas = 0;
        int totalPedacosPizzas = 0;
        int totalCervejas = 0;
        string continuar = "S";

        Console.WriteLine("Calculadora de contas da pizzaria");
        Console.WriteLine("---------------------------------");

        while (continuar.ToUpper() == "S")
        {
            Console.WriteLine($"- Mesa #{totalMesas+1}");

            Console.Write("Quantidade de pizzas: ");
            int quantidadePizzas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantidade de bebidas: ");
            int quantidadeBebidas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantidade de sobremesas: ");
            int quantidadeSobremesas = Convert.ToInt32(Console.ReadLine());

            double totalConta = (quantidadePizzas * valorPizza) +
                                (quantidadeBebidas * valorBebida) +
                                (quantidadeSobremesas * valorSobremesa);

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
            totalPizzas += quantidadePizzas;
            totalPedacosPizzas += quantidadePizzas * 8; // Cada pizza tem 8 pedaços
            totalCervejas += quantidadeBebidas;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Total da mesa: R$ {0:F2}", totalConta);
            Console.WriteLine("---------------------------------");

            Console.Write("Deseja calcular a conta de outra mesa? (S/N): ");
            continuar = Console.ReadLine();
        }

        double mediaGastoMesa = somaContas / totalMesas;
        double mediaGastoPessoa = somaContas / totalPessoas;
        double mediaPizzasMesa = (double)totalPizzas / totalMesas;
        double mediaPedacosPessoa = (double)totalPedacosPizzas / totalPessoas;
        double mediaCervejasMesa = (double)totalCervejas / totalMesas;

        Console.WriteLine("---------------------------------");
        Console.WriteLine("RESUMO DAS CONTAS");
        Console.WriteLine($"Maior conta: R$ {maiorConta:F2}");
        Console.WriteLine($"Menor conta: R$ {menorConta:F2}");
        Console.WriteLine($"Média de gasto por mesa: R$ {mediaGastoMesa:F2}");
        Console.WriteLine($"Média de gasto por pessoa: R$ {mediaGastoPessoa:F2}");
        Console.WriteLine($"Média de pizzas consumidas por mesa: {mediaPizzasMesa:F2}");
        Console.WriteLine($"Média de pedaços de pizza consumidos por pessoa: {mediaPedacosPessoa:F2}");
        Console.WriteLine($"Média de cervejas consumidas por mesa: {mediaCervejasMesa:F2}");
        Console.WriteLine("---------------------------------");
    }
}
