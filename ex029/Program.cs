//  29.	Serão lidos N números, faça um algoritmo que escreva o maior e o menor valor informado.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de números a serem informados: ");
        int quantidadeNumeros = Convert.ToInt32(Console.ReadLine());

        int maior = int.MinValue;
        int menor = int.MaxValue;

        for (int i = 1; i <= quantidadeNumeros; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > maior)
            {
                maior = numero;
            }

            if (numero < menor)
            {
                menor = numero;
            }
        }

        Console.WriteLine($"O menor valor informado é {menor}.");
        Console.WriteLine($"O maior valor informado é {maior}.");
    }
}
