using System;

namespace JogoDadosGabriel.ConsoleApp;

public class Program
{
    public static void Main(string[] args)
    {
        ExibirCabecalhoDoJogo();
       
        int linha_chegada = 30;

        Jogador jogador = new Jogador("Jogador");
        Jogador computador = new Jogador("Computador");

        while (jogador.pontuacao <= linha_chegada && computador.pontuacao <= linha_chegada)
        {
            jogador.RealizarJogada();

            Console.WriteLine("------------------------------------------");

            computador.RealizarJogada();

            Console.ReadLine();
            Console.Clear();

            if (jogador.pontuacao >= linha_chegada && computador.pontuacao < jogador.pontuacao)
                Console.WriteLine("Jogador ganhou");

            if (computador.pontuacao >= linha_chegada && computador.pontuacao > jogador.pontuacao)
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
