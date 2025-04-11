using System;

namespace JogoDadosGabriel.ConsoleApp;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao jogo de corrida de dados");

        Console.WriteLine("Trilha da Corrida");       

        int pont_jogador = 0;
        int pont_robo = 0;
        int linha_chegada = 30;

        while (pont_jogador <= linha_chegada && pont_robo <= linha_chegada)
        {
            bool rodadaExtraUsuario;

            do
            {
                rodadaExtraUsuario = false;

                Console.WriteLine("Jogador");
                Console.WriteLine("Pressione enter para rolar o dado");

                string rolar_dado = Console.ReadLine();

                Random random = new Random();

                int dado = random.Next(1, 6);

                Console.WriteLine("Jogador tirou: " + dado);

                pont_jogador = pont_jogador + dado;

                if (pont_jogador == 5 || pont_jogador == 10 || pont_jogador == 15 || pont_jogador == 25)
                {
                    Console.WriteLine("Evento Especial: Avanço Extra de 3 casas!");
                    Console.WriteLine("---------------------------------------------");

                    pont_jogador += 3;

                    Console.WriteLine($"Nova posição: {pont_jogador}!");
                }

                else if (pont_jogador == 7 || pont_jogador == 13 || pont_jogador == 20)
                {
                    Console.WriteLine("Evento Especial: Recuo de 2 casas!");
                    Console.WriteLine("---------------------------------------------");

                    pont_jogador -= 2;

                    Console.WriteLine($"Nova posição: {pont_jogador}!");
                }

                if (dado == 6)
                {
                    Console.WriteLine("Evento Especial: RODADA EXTRA!");
                    Console.WriteLine("---------------------------------------------");

                    rodadaExtraUsuario = true;
                }

                Console.WriteLine($"A posição do jogador é: {pont_jogador}");

            } while (rodadaExtraUsuario);

            Console.WriteLine("------------------------------------------");

            bool rodadaExtraRobo;

            do
            {
                rodadaExtraRobo = false;

                Console.WriteLine("Computador");
                Console.WriteLine("Pressione enter para rolar o dado");
                string rolar_dado = Console.ReadLine();

                Random random = new Random();
                int dado = random.Next(1, 6);

                Console.WriteLine("Computador tirou: " + dado);

                pont_robo = pont_robo + dado;

                if (pont_robo == 5 || pont_robo == 10 || pont_robo == 15 || pont_robo == 25)
                {
                    Console.WriteLine("Evento Especial: Avanço Extra de 3 casas!");
                    Console.WriteLine("---------------------------------------------");

                    pont_robo += 3;

                    Console.WriteLine($"Nova posição: {pont_robo}!");
                }

                else if (pont_robo == 7 || pont_robo == 13 || pont_robo == 20)
                {
                    Console.WriteLine("Evento Especial: Recuo de 2 casas!");
                    Console.WriteLine("---------------------------------------------");

                    pont_robo -= 2;

                    Console.WriteLine($"Nova posição: {pont_robo}!");
                }

                if (dado == 6)
                {
                    Console.WriteLine("Evento Especial: RODADA EXTRA!");
                    Console.WriteLine("---------------------------------------------");

                    rodadaExtraUsuario = true;
                }

                Console.WriteLine($"A posição do Robo é: {pont_robo}");

            } while (rodadaExtraRobo);

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
}
