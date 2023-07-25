//  22.	Faça um programa para escrever os números primos até um número informado pelo usuário.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int numeroInformado = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Números primos até {numeroInformado}: ");

        for (int numero = 2; numero <= numeroInformado; numero++)
        {
            bool ehPrimo = true;

            for (int divisor = 2; divisor < numero; divisor++)
            {
                if (numero % divisor == 0)
                {
                    ehPrimo = false;
                    break;
                }
            }

            if (ehPrimo)
            {
                Console.Write(numero + " ");
            }
        }

        Console.WriteLine();
    }
}
