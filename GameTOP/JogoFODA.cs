using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;

        public JogoFODA(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.corre());
            System.Console.Write(_jogadorA.chuta());
            System.Console.Write(_jogadorA.passa());

            System.Console.Write("\n PRÓXIMO JOGADOR \n");

            System.Console.Write(_jogadorB.corre());
            System.Console.Write(_jogadorB.chuta());
            System.Console.Write(_jogadorB.passa());            
        }
    }
    
}