using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string chuta()
        {
            return "Maradona estas pateando \n";
        }

        public string corre()
        {
            return "Maradona estas corriendo \n";
        }

        public string passa()
        {
            return "Maradona estas pasando \n";
        }
    }
}