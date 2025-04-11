using System;

namespace JogoDadosGabriel.ConsoleApp
{
    public class Jogo
    {
        Jogador jogador = new Jogador("Jogador");
        Jogador computador = new Jogador("Computador 01");

        int linha_chegada = 30;

        public bool NaoTerminou()
        {
            return jogador.pontuacao <= linha_chegada && computador.pontuacao <= linha_chegada;
        }

        public void RodarProximaRodada()
        {
            jogador.RealizarJogada();

            Console.WriteLine("------------------------------------------");

            computador.RealizarJogada();           

            if (jogador.pontuacao >= linha_chegada && computador.pontuacao < jogador.pontuacao)
                Console.WriteLine("Jogador ganhou");

            if (computador.pontuacao >= linha_chegada && computador.pontuacao > jogador.pontuacao)
                Console.WriteLine("Computador ganhou");
        }
    }
}