using System;

namespace JogoDadosGabriel.ConsoleApp;

public class Program
{
    public static void Main(string[] args)
    {
        ExibirCabecalhoDoJogo();
       
        int linha_chegada = 30;

        while (Jogo.pont_jogador <= linha_chegada && Jogo.pont_computador <= linha_chegada)
        {
            Jogo.JogadorRealizarJogada();

            Console.WriteLine("------------------------------------------");

            Jogo.ComputadorRelizarJogada();

            Console.ReadLine();
            Console.Clear();

            if (Jogo.pont_jogador >= linha_chegada && Jogo.pont_computador < Jogo.pont_jogador)
                Console.WriteLine("Jogador ganhou");

            if (Jogo.pont_computador >= linha_chegada && Jogo.pont_computador > Jogo.pont_jogador)
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
