// 47.	Agora desenvolva o algoritmo para informatizar o cálculo de uma churrascaria, considerando os menus:
// -	Bebidas 
// -   Rodízio
// -	Sobremesas 

// No final do processamento (no final do cálculo de todas as contas das mesas) as seguintes informações devem ser impressas:
// a.	A maior e a menor conta
// b.	A média de gasto por mesa
// c.	A média de gasto por pessoa
// d.	A média de rodízios por mesa


using System;

class Program
{
    static void Main(string[] args)
    {
        double valorBebida = 5.00;
        double valorRodizio = 30.00;
        double valorSobremesa = 8.00;

        double maiorConta = 0;
        double menorConta = double.MaxValue;
        double somaContas = 0;
        int totalMesas = 0;
        int totalPessoas = 0;
        int totalRodizios = 0;

        Console.WriteLine("Calculadora de contas da churrascaria");
        Console.WriteLine("-------------------------------------");

        string continuar = "S";
        while (continuar.ToUpper() == "S")
        {
            Console.WriteLine("Mesa #{0}", totalMesas + 1);

            double totalConta = 0;

            Console.Write("Deseja adicionar bebidas? (S/N): ");
            string adicionarBebidas = Console.ReadLine();

            if (adicionarBebidas.ToUpper() == "S")
            {
                Console.Write("Quantidade de bebidas: ");
                int quantidadeBebidas = int.Parse(Console.ReadLine());

                totalConta += quantidadeBebidas * valorBebida;
            }

            Console.Write("Deseja adicionar rodízios? (S/N): ");
            string adicionarRodizios = Console.ReadLine();

            if (adicionarRodizios.ToUpper() == "S")
            {
                Console.Write("Quantidade de rodízios: ");
                int quantidadeRodizios = int.Parse(Console.ReadLine());

                totalConta += quantidadeRodizios * valorRodizio;
            }

            Console.Write("Deseja adicionar sobremesas? (S/N): ");
            string adicionarSobremesas = Console.ReadLine();

            if (adicionarSobremesas.ToUpper() == "S")
            {
                Console.Write("Quantidade de sobremesas: ");
                int quantidadeSobremesas = int.Parse(Console.ReadLine());

                totalConta += quantidadeSobremesas * valorSobremesa;
            }

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
            totalRodizios += 1; // Considerando 1 rodízio por mesa

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Total da mesa: R$ {0:F2}", totalConta);
            Console.WriteLine("-------------------------------------");

            Console.Write("Deseja calcular a conta de outra mesa? (S/N): ");
            continuar = Console.ReadLine();
        }

        double mediaGastoMesa = somaContas / totalMesas;
        double mediaGastoPessoa = somaContas / totalPessoas;
        double mediaRodiziosMesa = (double)totalRodizios / totalMesas;

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Resumo das contas");
        Console.WriteLine("Maior conta: R$ {0:F2}", maiorConta);
        Console.WriteLine("Menor conta: R$ {0:F2}", menorConta);
        Console.WriteLine("Média de gasto por mesa: R$ {0:F2}", mediaGastoMesa);
        Console.WriteLine("Média de gasto por pessoa: R$ {0:F2}", mediaGastoPessoa);
        Console.WriteLine("Média de rodízios por mesa: {0:F2}", mediaRodiziosMesa);
        Console.WriteLine("-------------------------------------");
    }
}
