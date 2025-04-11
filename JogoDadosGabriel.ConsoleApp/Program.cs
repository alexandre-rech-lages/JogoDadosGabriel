using System;

namespace JogoDadosGabriel.ConsoleApp;

public class Program
{
    public static void Main(string[] args)
    {
        ExibirCabecalhoDoJogo();

        int pont_jogador = 0;
        int pont_computador = 0;
        int linha_chegada = 30;

        while (pont_jogador <= linha_chegada && pont_computador <= linha_chegada)
        {
            pont_jogador = Jogo.JogadorRealizarJogada(pont_jogador);

            Console.WriteLine("------------------------------------------");

            pont_computador = Jogo.ComputadorRelizarJogada(pont_computador);

            Console.ReadLine();
            Console.Clear();

            if (pont_jogador >= linha_chegada && pont_computador < pont_jogador)
                Console.WriteLine("Jogador ganhou");

            if (pont_computador >= linha_chegada && pont_computador > pont_jogador)
                Console.WriteLine("Computador ganhou");
        }

        Console.ReadLine();
    }

    private static void ExibirCabecalhoDoJogo()
    {
        Console.WriteLine("Bem vindo ao jogo de corrida de dados");

        Console.WriteLine("Trilha da Corrida");
    }

}
