// 8.	Faça um algoritmo para ler cinco números e imprimir o cubo e o quadrado de cada um deles.

using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int quadrado = num * num;
            int cubo = num * num * num;

            Console.WriteLine($"O quadrado de {num} é igual a {quadrado}.");
            Console.WriteLine($"O cubo de {num} é igual a {cubo}.");
        }
    }
}
