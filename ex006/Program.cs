// 6.	Elabore um algoritmo para calcular a soma dos números impares de 0 a 100.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int soma = 0;

        Console.WriteLine($"Os números de 1 até {num} são: ");
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
            soma += i;
        }

        Console.WriteLine($"A soma desses números é igual a {soma}.");
    }
}
