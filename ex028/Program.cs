//28.	Faça um algoritmo para imprimir uma tabela de conversão entre Dólar e Real. A cotação de um Dólar em real deve ser fornecida pelo usuário. A tabela deve conter até 1000 Dólares.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a cotação do dólar (US$) em reais (R$): ");
        double cotacao = double.Parse(Console.ReadLine());

        Console.WriteLine("Tabela de conversão de US$ x R$:");

        for (int dolares = 1; dolares <= 1000; dolares++)
        {
            double reais = dolares * cotacao;
            Console.WriteLine($"US$ {dolares} = R$ {reais:F2}");
        }
    }
}
