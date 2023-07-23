//  13.	Desenvolva um programa que permite para calcular a soma de números a partir do número 1 até um número informado pelo usuário. Por exemplo, se o usuário informar o número 5, o programa deverá calcular: 1 + 2 + 3 + 4 + 5 = 15, e mostrar o resultado para o usuário.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int soma = 0;

        for (int i = 1; i <= numero; i++)
        {
            soma += i;
        }

        Console.WriteLine($"A soma dos números de 1 até {numero} é igual a {soma}.");
    }
}
