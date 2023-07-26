// 26.	Elabore um algoritmo para gerar uma tabela de conversão entre milhas e Km, iniciando em 0 Km  e finalizado em 1000 km, e varie de 100 Km em 100 km,  sabendo-se que : 1 Milha = 1852 m.

using System;

class Program
{
    static void Main(string[] args)
    {
        const double milhaEmMetros = 1852;
        const int inicioKm = 0;
        const int fimKm = 1000;
        const int variacaoKm = 100;

        Console.WriteLine("Tabela de conversão de milhas para quilômetros:");

        for (int km = inicioKm; km <= fimKm; km += variacaoKm)
        {
            double milhas = km * milhaEmMetros / 1000;
            Console.WriteLine($"{km} km = {milhas} milhas");
        }
    }
}
