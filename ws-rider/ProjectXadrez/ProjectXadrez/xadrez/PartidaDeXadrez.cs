using System.Collections.Generic;
using tabuleiro;

namespace xadrez {
    class PartidaDeXadrez {
        public Tabuleiro Tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }
        private HashSet<Peca> Peca;
        private HashSet<Peca> Capturadas;


        public PartidaDeXadrez() {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            Peca = new HashSet<Peca>();
            Capturadas = new HashSet<Peca>();
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino) {
            Peca p = Tab.retirarPeca(origem);
            p.incrementarQtdMovimentos();
            Peca pecaCapturada = Tab.retirarPeca(destino);
            Tab.colocarPeca(p, destino);
            if (pecaCapturada != null) {
                Capturadas.Add(pecaCapturada);
            }
        }

        public void realizaJogada(Posicao origem, Posicao destino) {
            executaMovimento(origem, destino);
            Turno++;
            mudaJogador();
        }

        public void validarPosicaoOrigem(Posicao pos) {
            if (Tab.peca(pos) == null) {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida!");
            }

            if (JogadorAtual != Tab.peca(pos).Cor) {
                throw new TabuleiroException("A peça de origem escolhida não é sua!");
            }

            if (!Tab.peca(pos).existeMovimentosPossiveis()) {
                throw new TabuleiroException("Não há movimentos possiveis para a peça de origem escolhida!");
            }
        }

        public void validarPosicaoDeDestino(Posicao origem, Posicao destino) {
            if (!Tab.peca(origem).podeMoverPara(destino)) {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }
        
        private void mudaJogador() {
            if (JogadorAtual == Cor.Branca) {
                JogadorAtual = Cor.Preto;
            }
            else {
                JogadorAtual = Cor.Branca;
            }
        }

        public HashSet<Peca> pecasCapturadas(Cor cor) {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in Capturadas) {
                if (x.Cor == cor) {
                    aux.Add(x);
                }     
            }

            return aux;
        }

        public HashSet<Peca> pecasEmJogo(Cor cor) {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in Peca) {
                if (x.Cor == cor) {
                    aux.Add(x);
                }
            }
            // Remover as peças capturadas das peças em jogo
            aux.ExceptWith(pecasCapturadas(cor));
            return aux;
        }

        public void colocarNovaPeca(char coluna, int linha, Peca peca) {
            Tab.colocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
            Peca.Add(peca);
        }

        private void colocarPecas() {
            colocarNovaPeca('c', 8, new Torre(Tab, Cor.Preto));
            colocarNovaPeca('c', 7, new Torre(Tab, Cor.Preto));
            colocarNovaPeca('d', 7, new Torre(Tab, Cor.Preto));
            colocarNovaPeca('e', 8, new Torre(Tab, Cor.Preto));
            colocarNovaPeca('e', 7, new Torre(Tab, Cor.Preto));
            colocarNovaPeca('d', 8, new Rei(Tab, Cor.Preto));

            colocarNovaPeca('c', 1, new Torre(Tab, Cor.Branca));
            colocarNovaPeca('c', 2, new Torre(Tab, Cor.Branca));
            colocarNovaPeca('d', 2, new Torre(Tab, Cor.Branca));
            colocarNovaPeca('e', 1, new Torre(Tab, Cor.Branca));
            colocarNovaPeca('e', 2, new Torre(Tab, Cor.Branca));
            colocarNovaPeca('d', 1, new Rei(Tab, Cor.Branca));
        }
    }
}
