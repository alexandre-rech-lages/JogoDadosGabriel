using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDadosGabriel.ConsoleApp;

public class Jogo
{
    public static int pont_jogador = 0;
    public static int pont_computador = 0;

    public static void ComputadorRelizarJogada()
    {
        bool rodadaExtraComputador;

        do
        {
            string rolar_dado = Console.ReadLine();

            Console.WriteLine("Turno - Computador");

            int dado = RolarDado("Computador");

            pont_computador += dado;

            VerificarEventosEspeciais("Computador");

            rodadaExtraComputador = TemRodadaExtra(dado);

        } while (rodadaExtraComputador);        
    }

    public static void JogadorRealizarJogada()
    {
        bool rodadaExtraJogador;

        do
        {
            string rolar_dado = Console.ReadLine();

            Console.WriteLine("Turno - Jogador");

            int dado = RolarDado("Jogador");

            pont_jogador += dado;

            VerificarEventosEspeciais("Jogador");

            rodadaExtraJogador = TemRodadaExtra(dado);

        } while (rodadaExtraJogador);        
    }

    public static void VerificarEventosEspeciais(string tipoJogador)
    {
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

        Console.WriteLine($"A posição do {tipoJogador} é: {pont_jogador}");        
    }

    public static bool TemRodadaExtra(int dado)
    {
        bool rodadaExtra = false;

        if (dado == 6)
        {
            Console.WriteLine("Evento Especial: RODADA EXTRA!");
            Console.WriteLine("---------------------------------------------");

            rodadaExtra = true;
        }

        return rodadaExtra;
    }

    public static int RolarDado(string tipoJogador)
    {
        Console.WriteLine("Pressione enter para rolar o dado");

        Random random = new Random();

        int dado = random.Next(1, 6);

        Console.WriteLine($"{tipoJogador} tirou: " + dado);

        return dado;
    }
}
