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
        public bool Xeque { get; private set; }


        public PartidaDeXadrez() {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            Xeque = false;
            Peca = new HashSet<Peca>();
            Capturadas = new HashSet<Peca>();
            colocarPecas();
        }

        public Peca executaMovimento(Posicao origem, Posicao destino) {
            Peca p = Tab.retirarPeca(origem);
            p.incrementarQtdMovimentos();
            Peca pecaCapturada = Tab.retirarPeca(destino);
            Tab.colocarPeca(p, destino);
            if (pecaCapturada != null) {
                Capturadas.Add(pecaCapturada);
            }

            return pecaCapturada;
        }

        public void desfazMovimento(Posicao origem, Posicao destino, Peca pecaCapturada) {
            Peca p = Tab.retirarPeca(destino);
            p.decrementarQtdMovimentos();
            if (pecaCapturada != null) {
                Tab.colocarPeca(pecaCapturada, destino);
                Capturadas.Remove(pecaCapturada);
            }
            Tab.colocarPeca(p, origem);
        }

        public void realizaJogada(Posicao origem, Posicao destino) {
            Peca pecaCapturada = executaMovimento(origem, destino);

            if (estaEmXeque(JogadorAtual)) {
                desfazMovimento(origem, destino, pecaCapturada);
                throw new TabuleiroException("Você não pode se colocar em xeque!");
            }

            if (estaEmXeque(adversaria(JogadorAtual))) {
                Xeque = true;
            }
            else {
                Xeque = false;
            }

            if (testeXequemate(adversaria(JogadorAtual))) {
                Terminada = true;
            }
            else {
                Turno++;
                mudaJogador();
            }
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

        private Cor adversaria(Cor cor) {
            if (cor == Cor.Branca) {
                return Cor.Preto;
            }
            else {
                return Cor.Branca;
            }
        }

        private Peca rei(Cor cor) {
            foreach (Peca x in pecasEmJogo(cor)) {
                if (x is Rei) {
                    return x;
                }
            }

            return null;
        }

        public bool estaEmXeque(Cor cor) {
            Peca R = rei(cor);
            if (R == null) {
                throw new TabuleiroException("Não tem rei da cor " + cor + " no tabuleiro!");
            }
            foreach (Peca x in pecasEmJogo(adversaria(cor))) {
                bool[,] mat = x.movimentosPossiveis();
                if (mat[R.Posicao.Linha, R.Posicao.Coluna]) {
                    return true;
                }
            }

            return false;
        }

        public bool testeXequemate(Cor cor) {
            if (!estaEmXeque(cor)) {
                return false;
            }

            foreach (Peca x in pecasEmJogo(cor)) {
                bool[,] mat = x.movimentosPossiveis();
                for (int i = 0; i < Tab.Linhas; i++) {
                    for (int j = 0; j < Tab.Colunas; j++) {
                        Posicao origem = x.Posicao;
                        Posicao destino = new Posicao(i, j);
                        Peca pecaCapturada = executaMovimento(origem, destino);
                        bool testeXeque = estaEmXeque(cor);
                        desfazMovimento(origem, destino, pecaCapturada);
                        if (!testeXeque) {
                            return false;
                        }
                    }
                }
            }

            return true;
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
