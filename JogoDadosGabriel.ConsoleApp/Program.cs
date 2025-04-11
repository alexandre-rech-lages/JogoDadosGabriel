using System;

namespace JogoDadosGabriel.ConsoleApp;

public class Program
{
    public static void Main(string[] args)
    {       
        Console.WriteLine("Bem vindo ao jogo de corrida de dados");

        Console.WriteLine("Trilha da Corrida");

        int[] trilha = new int[31];

        ConfigurarTrilha(trilha);

        MostrarTrilha(trilha);

        int pont_jogador = 0;
        int pont_robo = 0;
        int linha_chegada = 30;
        string controle = "a";

        while (controle != "x" && controle != "X" && pont_jogador <= linha_chegada && pont_robo <= linha_chegada)
        {
            Console.WriteLine("Jogador");
            Console.WriteLine("Pressione enter para rolar o dado");

            string rolar_dado = Console.ReadLine();

            Random random = new Random();

            int dado = random.Next(1, 6);

            Console.WriteLine("Jogador tirou: " + dado);

            pont_jogador = pont_jogador + dado;

            Console.WriteLine($"A posição do jogador é: {pont_jogador}");

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Computador");
            Console.WriteLine("Pressione enter para rolar o dado");
            rolar_dado = Console.ReadLine();

            dado = random.Next(1, 6);

            Console.WriteLine("Computador tirou: " + dado);

            pont_robo = pont_robo + dado;            

            Console.WriteLine($"A posição do Robo é: {pont_robo}");

            Console.ReadLine();
            Console.Clear();

            if (pont_jogador >= linha_chegada && pont_robo < pont_jogador) 
            {
                Console.WriteLine("Jogador ganhou");
            }

            if (pont_robo >= linha_chegada && pont_robo > pont_jogador)
            {
                Console.WriteLine("Computador ganhou");
            }            
        }

        Console.ReadLine();
    }

    public static void ConfigurarTrilha(int[] novaTrilha)
    {
        for (int i = 0; i < novaTrilha.Length; i++)
        {
            novaTrilha[i] = i;
        }
    }

    static void MostrarTrilha(int[] trilha)
    {
        for (int i = 0; i < trilha.Length; i++)
        {
            Console.Write(trilha[i]);

            if (i < 30)
                Console.Write(", ");
        }
    }
}
