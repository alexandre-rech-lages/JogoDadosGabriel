using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDadosGabriel.ConsoleApp;

public class Jogo
{
    public static int ComputadorRelizarJogada(int pont_computador)
    {
        bool rodadaExtraComputador;

        do
        {
            string rolar_dado = Console.ReadLine();

            Console.WriteLine("Turno - Computador");

            int dado = RolarDado("Computador");

            pont_computador += dado;

            VerificarEventosEspeciais(ref pont_computador, "Computador");

            rodadaExtraComputador = TemRodadaExtra(dado);

        } while (rodadaExtraComputador);

        return pont_computador;
    }

    public static int JogadorRealizarJogada(int pont_jogador)
    {
        bool rodadaExtraJogador;

        do
        {
            string rolar_dado = Console.ReadLine();

            Console.WriteLine("Turno - Jogador");

            int dado = RolarDado("Jogador");

            pont_jogador += dado;

            VerificarEventosEspeciais(ref pont_jogador, "Jogador");

            rodadaExtraJogador = TemRodadaExtra(dado);

        } while (rodadaExtraJogador);
        return pont_jogador;
    }

    public static int VerificarEventosEspeciais(ref int pontuacao, string tipoJogador)
    {
        if (pontuacao == 5 || pontuacao == 10 || pontuacao == 15 || pontuacao == 25)
        {
            Console.WriteLine("Evento Especial: Avanço Extra de 3 casas!");
            Console.WriteLine("---------------------------------------------");

            pontuacao += 3;

            Console.WriteLine($"Nova posição: {pontuacao}!");
        }

        else if (pontuacao == 7 || pontuacao == 13 || pontuacao == 20)
        {
            Console.WriteLine("Evento Especial: Recuo de 2 casas!");
            Console.WriteLine("---------------------------------------------");

            pontuacao -= 2;

            Console.WriteLine($"Nova posição: {pontuacao}!");
        }

        Console.WriteLine($"A posição do {tipoJogador} é: {pontuacao}");

        return pontuacao;
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
