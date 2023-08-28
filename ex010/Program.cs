// 10.	Faça um algoritmo para um intervalo de números informados pelo usuário e calcular, para cada número, a raiz quadrada e sua metade.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o limite inferior do intervalo: ");
        int limiteInferior = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o limite superior do intervalo: ");
        int limiteSuperior = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Cálculo da raiz quadrada e da metade no intervalo entre {limiteInferior} e {limiteSuperior}: ");

        for (int i = limiteInferior; i <= limiteSuperior; i++)
        {
            double raizQuadrada = Math.Sqrt(i);
            double metade = i / 2.0;

            Console.WriteLine($"Número: {i}");
            Console.WriteLine($"Raiz quadrada: {raizQuadrada:F2}");
            Console.WriteLine($"Metade: {metade}");
            Console.WriteLine("================================================");
        }
    }
}
