//  27.	Crie uma tabela de conversão de polegada para centímetros. A tabela deve conter valores de 1 a 100 polegadas. Cada polegada equivale a 2,54 cm.

using System;

class Program
{
    static void Main(string[] args)
    {
        const double polegadaEmCm = 2.54;
        const int inicioPolegada = 1;
        const int fimPolegada = 100;

        Console.WriteLine("Tabela de conversão de polegadas para centímetros:");

        for (int polegada = inicioPolegada; polegada <= fimPolegada; polegada++)
        {
            double centimetros = polegada * polegadaEmCm;
            Console.WriteLine($"{polegada} polegada(s) = {centimetros:F2} cm");
        }
    }
}
