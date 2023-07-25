// 21.	Faça um programa que calcule e escreva o valor de S.

//           1	           3 	      5	                    99
// S =    --------  +	-------  + -------   +   ...  +   -----
//           1	           2	      3		                50

using System;

class Program
{
    static void Main(string[] args)
    {
        double S = 0;

        for (int numerador = 1, divisor = 1; numerador <= 99; numerador += 2, divisor++)
        {
            double termo = numerador / divisor;
            S += termo;
        }

        Console.WriteLine($"O valor de S é igual a {S}.");
    }
}
