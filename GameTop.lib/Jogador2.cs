using GameTop.Interface;

namespace GameTop.lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
           return "Maradona está chutando \n";
        }

        public string Corre()
        {
           return "Maradona está correndo \n";
        }

        public string Passe()
        {
           return "Maradona está passando \n";
        }
    }
}