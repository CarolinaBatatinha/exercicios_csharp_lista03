// 4.	Faça um algoritmo para imprimir os múltiplos de 5 em um intervalo informado pelo usuário.

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número do intervalo: ");
        int numInicial = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o último número do intervalo: ");
        int numFinal = Convert.ToInt32(Console.ReadLine());

        for (int i = numInicial; i <= numFinal; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
