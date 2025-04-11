using System;

namespace JogoDadosGabriel.ConsoleApp;

public class Program
{
    public static void Main(string[] args)
    {
        ExibirCabecalhoDoJogo();              

        Jogo jogo = new Jogo();

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
