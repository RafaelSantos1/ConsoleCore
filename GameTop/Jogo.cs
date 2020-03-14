

using GameTop.Interface;

namespace GameTop
{
    class Jogo
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;
        public Jogo(IJogador jogadorA,IJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
           System.Console.Write(_jogadorA.Corre()); 
           System.Console.Write(_jogadorA.Chuta()); 
           System.Console.Write(_jogadorA.Passe()); 

           System.Console.Write(_jogadorB.Corre()); 
           System.Console.Write(_jogadorB.Chuta()); 
           System.Console.Write(_jogadorB.Passe()); 
        }
    }
}