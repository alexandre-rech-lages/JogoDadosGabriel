using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDadosGabriel.ConsoleApp;

public class Jogador
{
    public int pontuacao = 0;
    public string tipoJogador;

    //método constructor
    public Jogador(string tipoJogador)
    {
        this.tipoJogador = tipoJogador;
    }   

    public void RealizarJogada()
    {
        bool rodadaExtraJogador;

        do
        {
            string rolar_dado = Console.ReadLine();

            Console.WriteLine($"Turno - {tipoJogador}");

            int dado = RolarDado();

            pontuacao += dado;

            VerificarEventosEspeciais();

            rodadaExtraJogador = TemRodadaExtra(dado);

        } while (rodadaExtraJogador);
    }

    public void VerificarEventosEspeciais()
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
    }  

    public bool TemRodadaExtra(int dado)
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

    public int RolarDado()
    {
        Console.WriteLine("Pressione enter para rolar o dado");

        Random random = new Random();

        int dado = random.Next(1, 6);

        Console.WriteLine($"{tipoJogador} tirou: " + dado);

        return dado;
    }
}
