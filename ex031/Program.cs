// 31.	Suponha que serão digitados 100 números inteiros via teclado, faça um algoritmo para:
// •	Somar os números positivos
// •	Contar os números negativos.
// •	A média dos números negativos e a média dos números positivos.
// •	A diferença entre o total de números positivos e negativos

using System;

class Program
{
    static void Main(string[] args)
    {
        const int quantidadeNumeros = 10;

        int somaPositivos = 0;
        int contadorNegativos = 0;
        int totalPositivos = 0;
        int totalNegativos = 0;

        for (int i = 1; i <= quantidadeNumeros; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                somaPositivos += numero;
                totalPositivos++;
            }
            else if (numero < 0)
            {
                contadorNegativos++;
                totalNegativos++;
            }
        }

        double mediaPositivos = totalPositivos > 0 ? (double)somaPositivos / totalPositivos : 0;
        double mediaNegativos = totalNegativos > 0 ? (double)contadorNegativos / totalNegativos : 0;
        int diferenca = totalPositivos - totalNegativos;

        Console.WriteLine($"Soma dos números positivos: {somaPositivos}");
        Console.WriteLine($"Quantidade de números negativos: {contadorNegativos}");
        Console.WriteLine($"Média dos números positivos: {mediaPositivos}");
        Console.WriteLine($"Média dos números negativos: {mediaNegativos}");
        Console.WriteLine($"Diferença entre o total de números positivos e negativos: {diferenca}");
    }
}
