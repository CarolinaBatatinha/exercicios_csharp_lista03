// 7.	Elabore um algoritmo para calcular a soma dos números impares de 1000 a 10.

using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;

        for (int i = 1000; i >= 10; i--)
        {
            if (i % 2 != 0)
            {
                soma += i;
            }
        }

        Console.WriteLine($"A soma dos números ímpares de 1000 a 10 é igual a {soma}.");
    }
}
