// 42.	Você foi contratado pelo melhor time de futebol do mundo, para fazer um programa que: durante um jogo de futebol, leia um fato ocorrido no jogo, este fato pode ser :
// 0-   Fim da partida
// 1-	Faltas cometidas
// 2-	Faltas recebidas
// 3-	Escanteios a Favor
// 4-	Passes Errados
// 5-	Chutes a gol

// Ao final da partida o programa deverá imprimir os totais de cada fato.

using System;

class Program
{
    static void Main(string[] args)
    {
        int fimPartida = 0;
        int faltasCometidas = 0;
        int faltasRecebidas = 0;
        int escanteiosAFavor = 0;
        int passesErrados = 0;
        int chutesAGol = 0;
        int evento;
        Console.WriteLine("Registro de eventos do jogo de futebol");
        Console.WriteLine("Digite o código do evento (0 a 5), 0 para encerrar a partida:");
        Console.WriteLine(
            "0 - Fim da partida\n1 - Faltas cometidas\n2 - Faltas recebidas\n3 - Escanteios a Favor\n4 - Passes Errados \n5 - Chutes a gol"
        );

        do
        {
            Console.Write("Evento: ");
            evento = int.Parse(Console.ReadLine());

            switch (evento)
            {
                case 0:
                    fimPartida++;
                    break;
                case 1:
                    faltasCometidas++;
                    break;
                case 2:
                    faltasRecebidas++;
                    break;
                case 3:
                    escanteiosAFavor++;
                    break;
                case 4:
                    passesErrados++;
                    break;
                case 5:
                    chutesAGol++;
                    break;
                default:
                    Console.WriteLine("Código de evento inválido. Tente novamente.");
                    break;
            }
        } while (evento != 0);
        Console.WriteLine("===========================================================");
        Console.WriteLine("FIM DA PARTIDA\n");
        Console.WriteLine($"Total de eventos:");
        Console.WriteLine($"Faltas cometidas: {faltasCometidas}");
        Console.WriteLine($"Faltas recebidas: {faltasRecebidas}");
        Console.WriteLine($"Escanteios a favor: {escanteiosAFavor}");
        Console.WriteLine($"Passes errados: {passesErrados}");
        Console.WriteLine($"Chutes a gol: {chutesAGol}");
    }
}
