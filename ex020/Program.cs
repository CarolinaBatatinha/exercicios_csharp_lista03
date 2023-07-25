//  Fazer um programa que calcule e escreva o valor de S.
//       37*38      36*37     35*36           1*2
//  S = -------- + ------- + ------- + ... + -----
//          1        2          3             37

using System;

class Program
{
    static void Main(string[] args)
    {
        double S = 0;
        for (int numerador = 37, divisor = 1; numerador >= 1; numerador--, divisor++)
        {
            double termo = (numerador * (numerador + 1)) / divisor;
            S += termo;
        }

        Console.WriteLine($"O valor de S é igual a {S}.");
    }
}
