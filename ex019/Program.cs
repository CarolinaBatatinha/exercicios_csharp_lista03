//  19.	Construir um programa que calcule a soma dos N primeiros números inteiros, onde N será digitado pelo usuário. Por exemplo,  soma = 1 + 2 + 3 + 4 + ..... + N.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro positivo: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int soma = 0;

        for (int i = 1; i <= N; i++)
        {
            soma += i;
        }

        Console.WriteLine($"A soma dos primeiros {N} números inteiros é igual a {soma}.");
    }
}
