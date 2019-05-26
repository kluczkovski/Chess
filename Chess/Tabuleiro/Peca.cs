
namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get;  protected set; }
        public int QtdMovimento { get; protected set; }
        public Tabuleiro Tabuleiro { get; set; }

        public Peca()
        {
        }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = posicao;
            Tabuleiro = tabuleiro;
            Cor = cor;
            QtdMovimento = 0;
        }
    }
}
