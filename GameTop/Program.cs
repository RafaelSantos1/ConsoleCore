using System;
using GameTop.lib;
namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Jogo(new Jogador1("Rafael"),new Jogador2());
            jogo.IniciarJogo();
        }
    }
   
}
