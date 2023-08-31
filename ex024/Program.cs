//  24.	Será digitado uma série de números inteiros. Faça um algoritmo para calcular e imprimir o produto desses valores, isto é, o resultado da multiplicação de todos os números. Número de entrada desconhecido.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma série de números inteiros (digite 0 para encerrar):");

        int produto = 1;
        int numero;

        do
        {
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero != 0)
            {
                produto *= numero;
            }
        } while (numero != 0);

        Console.WriteLine($"O produto dos números é igual a {produto}.");
    }
}
