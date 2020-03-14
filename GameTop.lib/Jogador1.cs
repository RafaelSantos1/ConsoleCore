
using GameTop.Interface;

namespace GameTop.lib
{
   public class Jogador1 : IJogador
    {
        public string _Nome { get; set; }
        public Jogador1(string Nome)
        {
            _Nome = Nome;
        }

        public string Chuta()
        {
            return $"{_Nome} está chutando \n";
        }
        
        public string Corre()
        {
            return $"{_Nome} está correndo \n";
        }
        
        public string Passe()
        {
            return $"{_Nome} está passando \n";
        }
    }
}