using System;

namespace JogoDadosGabriel.ConsoleApp;

public class Program
{
    static Jogo jogo;
    public static void Main(string[] args)
    {
        ExibirCabecalhoDoJogo();

        jogo = new Jogo();

        while (jogo.NaoTerminou())
            jogo.RodarProximaRodada();

        Console.ReadLine();
    }

    private static void ExibirCabecalhoDoJogo()
    {
        Console.WriteLine("Bem vindo ao jogo de corrida de dados");

        Console.WriteLine("Trilha da Corrida");
    }

}
