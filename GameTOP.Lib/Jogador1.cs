using GameTOP.Interface;

namespace GameTOP.Lib
{
       public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }


        //Chuta
        public string chuta()
        {
            return $"{_Nome} está chutando \n";
        }
        
        //Corre
        public string corre()
        {
            return $"{_Nome} está correndo \n";
        }
        //Passa
        public string passa()
        {
            return $"{_Nome} está passando \n";
        }
    }

}