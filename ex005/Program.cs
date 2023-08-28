// 5.	Faça um algoritmo que imprima todos os números de 1 até um número especificado pelo usuário e a soma deles.

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int soma = 0;

        Console.WriteLine($"Os números de 1 até {numero} são: ");
        for (int i = 1; i <= numero; i++)
        {
            Console.WriteLine(i);
            soma += i;
        }

        Console.WriteLine($"A soma desses números é igual a {soma}.");
    }
}
