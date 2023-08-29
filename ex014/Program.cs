// 14.	Faça um algoritmo para imprimir os números pares entre 8 e 18.

using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 8; i <= 18; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}
