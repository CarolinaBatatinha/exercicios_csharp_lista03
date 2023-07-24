// 17.	Desenvolva um algoritmo para calcular o fatorial de um número. Por exemplo: 0! = 1, 1! = 1 e 5!= 5x4x3x2x1 = 120. Lembre-se, não existe fatorial de número negativo e de número real.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro não negativo: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("O fatorial não está definido para números negativos.");
        }
        else
        {
            int fatorial = 1;

            for (int i = 2; i <= numero; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"O fatorial de {numero} é igual a {fatorial}.");
        }
    }
}
