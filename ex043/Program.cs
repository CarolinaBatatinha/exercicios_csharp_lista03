// 43.	Uma confecção vende conjuntos de malha em dois tamanhos: pequeno a R$ 50.00 e grande R$ 70,00 cada. Para pedidos superiores a 200 conjuntos os valores são reduzidos em 10 %. Se o pedido for superior a 1000 unidades a confecção oferece um desconto de 15 % para o tamanho grande e 13 % para o tamanho pequeno. Faça um algoritmo para ler o nome do cliente e um pedido (tamanho e quantidade) e imprimir o nome do cliente, o valor bruto, o desconto concedido e o valor a pagar.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o nome do cliente: ");
        string nomeCliente = Console.ReadLine();

        Console.WriteLine("Informe o tamanho do conjunto (P - pequeno ou G - grande): ");
        string tamanhoConjunto = Console.ReadLine();

        Console.WriteLine("Informe a quantidade de conjuntos:");
        int quantidadeConjuntos = int.Parse(Console.ReadLine());

        double valorUnitario = 0;
        double desconto = 0;

        if (tamanhoConjunto.ToUpper() == "P")
        {
            valorUnitario = 50.00;
            if (quantidadeConjuntos > 1000)
            {
                desconto = 0.13;
            }
        }
        else if (tamanhoConjunto.ToUpper() == "G")
        {
            valorUnitario = 70.00;
            if (quantidadeConjuntos > 1000)
            {
                desconto = 0.15;
            }
        }

        double valorBruto = valorUnitario * quantidadeConjuntos;
        double valorDesconto = valorBruto * desconto;
        double valorFinal = valorBruto - valorDesconto;

        Console.WriteLine("---------------------------");
        Console.WriteLine($"Cliente: {nomeCliente}");
        Console.WriteLine($"Valor bruto: R$ {valorBruto:F2}");
        Console.WriteLine($"Desconto concedido: {desconto:P}");
        Console.WriteLine($"Valor a pagar: R$ {valorFinal:F2}");
    }
}
