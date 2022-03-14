using System.Collections.Generic;
using System.ComponentModel;
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
        public Peca _vulneravelEnPassant { get; private set; }


        public PartidaDeXadrez() {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            Xeque = false;
            _vulneravelEnPassant = null;
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
            
            // #jogadaespecial roque pequeno
            if (p is Rei && destino.Coluna == origem.Coluna + 2) {
                Posicao origemTorre = new Posicao(origem.Linha, origem.Coluna + 3);
                Posicao destinoTorre = new Posicao(origem.Linha, origem.Coluna + 1);
                // Movendo a torre
                Peca T = Tab.retirarPeca(origemTorre);
                T.incrementarQtdMovimentos();
                Tab.colocarPeca(T, destinoTorre);
            }
            
            // #jogadaespecial roque grande
            if (p is Rei && destino.Coluna == origem.Coluna - 2) {
                Posicao origemTorre = new Posicao(origem.Linha, origem.Coluna - 4);
                Posicao destinoTorre = new Posicao(origem.Linha, origem.Coluna - 1);
                // Movendo a torre
                Peca T = Tab.retirarPeca(origemTorre);
                T.incrementarQtdMovimentos();
                Tab.colocarPeca(T, destinoTorre);
            }
            
            // #jogadaespecial en passant
            if (p is Peao) {
                if (origem.Coluna != destino.Coluna && pecaCapturada == null) {
                    Posicao posP;
                    if (p.Cor == Cor.Branca) {
                        posP = new Posicao(destino.Linha + 1, destino.Coluna);
                    }
                    else {
                        posP = new Posicao(destino.Linha - 1, destino.Coluna);
                    }

                    pecaCapturada = Tab.retirarPeca(posP);
                    Capturadas.Add(pecaCapturada);
                }
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
            
            // desfazendo #jogadaespecial roque pequeno
            if (p is Rei && destino.Coluna == origem.Coluna + 2) {
                Posicao origemTorre = new Posicao(origem.Linha, origem.Coluna + 3);
                Posicao destinoTorre = new Posicao(origem.Linha, origem.Coluna + 1);
                // Movendo a torre
                Peca T = Tab.retirarPeca(destinoTorre);
                T.decrementarQtdMovimentos();
                Tab.colocarPeca(T, origemTorre);
            }
            
            // desfazendo #jogadaespecial roque grande
            if (p is Rei && destino.Coluna == origem.Coluna - 2) {
                Posicao origemTorre = new Posicao(origem.Linha, origem.Coluna - 4);
                Posicao destinoTorre = new Posicao(origem.Linha, origem.Coluna - 1);
                // Movendo a torre
                Peca T = Tab.retirarPeca(destinoTorre);
                T.decrementarQtdMovimentos();
                Tab.colocarPeca(T, origemTorre);
            }
            
            // desfazendo #jogadaespecial en passant
            if (p is Peao) {
                if (origem.Coluna != destino.Coluna && pecaCapturada == _vulneravelEnPassant) {
                    Peca peao = Tab.retirarPeca(destino);
                    Posicao posP;
                    if (p.Cor == Cor.Branca) {
                        posP = new Posicao(3, destino.Coluna);
                    }
                    else {
                        posP = new Posicao(4, destino.Coluna);
                    }
                    Tab.colocarPeca(peao, posP);
                }
            }
        }

        public void realizaJogada(Posicao origem, Posicao destino) {
            Peca pecaCapturada = executaMovimento(origem, destino);

            if (estaEmXeque(JogadorAtual)) {
                desfazMovimento(origem, destino, pecaCapturada);
                throw new TabuleiroException("Você não pode se colocar em xeque!");
            }
            
            Peca p = Tab.peca(destino);
            
            // #jogadaespecial promoção
            if (p is Peao) {
                if ((p.Cor == Cor.Branca && destino.Linha == 0) || (p.Cor == Cor.Preto && destino.Linha == 7)) {
                    // Removendo a peça
                    p = Tab.retirarPeca(destino);
                    Peca.Remove(p);
                    // Criando a nova dama
                    Peca dama = new Dama(Tab, p.Cor);
                    // Colocando a nova dama no jogo
                    Tab.colocarPeca(dama, destino);
                    Peca.Add(dama);
                }
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

            // #jogadaespecial en passant
            if (p is Peao && (destino.Linha == origem.Linha - 2 || destino.Linha == origem.Linha + 2)) {
                _vulneravelEnPassant = p;
            }
            else {
                _vulneravelEnPassant = null;
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
            if (!Tab.peca(origem).movimentoPossivel(destino)) {
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
                        if (mat[i, j]) {
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
            }

            return true;
        }

        public void colocarNovaPeca(char coluna, int linha, Peca peca) {
            Tab.colocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
            Peca.Add(peca);
        }

        private void colocarPecas() {
            // Peça Branca
            colocarNovaPeca('a', 1, new Torre(Tab, Cor.Branca));
            colocarNovaPeca('b', 1, new Cavalo(Tab, Cor.Branca));
            colocarNovaPeca('c', 1, new Bispo(Tab, Cor.Branca));
            colocarNovaPeca('d', 1, new Dama(Tab, Cor.Branca));
            colocarNovaPeca('e', 1, new Rei(Tab, Cor.Branca, this));
            /*
             * Obs.: Como já estou na classe PartidaDeXadrez e o constructor de Rei pede as informações da partida,
             * que no caso é a partida de xadres, basta utilizar o this para poder passar toda a classe.
             */
            colocarNovaPeca('f', 1, new Bispo(Tab, Cor.Branca));
            colocarNovaPeca('g', 1, new Cavalo(Tab, Cor.Branca));
            colocarNovaPeca('h', 1, new Torre(Tab, Cor.Branca));
            // Peao
            colocarNovaPeca('a', 2, new Peao(Tab, Cor.Branca, this));
            colocarNovaPeca('b', 2, new Peao(Tab, Cor.Branca, this));
            colocarNovaPeca('c', 2, new Peao(Tab, Cor.Branca, this));
            colocarNovaPeca('d', 2, new Peao(Tab, Cor.Branca, this));
            colocarNovaPeca('e', 2, new Peao(Tab, Cor.Branca, this));
            colocarNovaPeca('f', 2, new Peao(Tab, Cor.Branca, this));
            colocarNovaPeca('g', 2, new Peao(Tab, Cor.Branca, this));
            colocarNovaPeca('h', 2, new Peao(Tab, Cor.Branca, this));
            
            // Peça Preta
            colocarNovaPeca('a', 8, new Torre(Tab, Cor.Preto));
            colocarNovaPeca('b', 8, new Cavalo(Tab, Cor.Preto));
            colocarNovaPeca('c', 8, new Bispo(Tab, Cor.Preto));
            colocarNovaPeca('d', 8, new Dama(Tab, Cor.Preto));
            colocarNovaPeca('e', 8, new Rei(Tab, Cor.Preto, this));
            /*
             * Obs.: Como já estou na classe PartidaDeXadrez e o constructor de Rei pede as informações da partida,
             * que no caso é a partida de xadres, basta utilizar o this para poder passar toda a classe.
             */
            colocarNovaPeca('f', 8, new Bispo(Tab, Cor.Preto));
            colocarNovaPeca('g', 8, new Cavalo(Tab, Cor.Preto));
            colocarNovaPeca('h', 8, new Torre(Tab, Cor.Preto));
            // Peao
            colocarNovaPeca('a', 7, new Peao(Tab, Cor.Preto, this));
            colocarNovaPeca('b', 7, new Peao(Tab, Cor.Preto, this));
            colocarNovaPeca('c', 7, new Peao(Tab, Cor.Preto, this));
            colocarNovaPeca('d', 7, new Peao(Tab, Cor.Preto, this));
            colocarNovaPeca('e', 7, new Peao(Tab, Cor.Preto, this));
            colocarNovaPeca('f', 7, new Peao(Tab, Cor.Preto, this));
            colocarNovaPeca('g', 7, new Peao(Tab, Cor.Preto, this));
            colocarNovaPeca('h', 7, new Peao(Tab, Cor.Preto, this));
        }
    }
}
