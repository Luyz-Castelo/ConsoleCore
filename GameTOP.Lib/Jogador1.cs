using GameTOP.Interface;

namespace GameTOP.Lib
{
public class Jogador1 : iJogador
    {
        public readonly string Nome;

        public Jogador1(){}
        public Jogador1(string nome)
        {
            Nome = nome;
        }
        public string Chuta()
        {
            return $"{Nome} está chutando \n";
        }
        public string Corre()
        {
            return $"{Nome} está correndo \n";
        }
        public string Passe()
        {
            return $"{Nome} está passando \n";
        }
    }
}