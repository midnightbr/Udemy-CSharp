﻿using tabuleiro;

namespace xadrez {
    public class PosicaoXadrez {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha) {
            Coluna = coluna;
            Linha = linha;
        }

        // Converte de Posição no tabuleiro para Posição na matriz
        public Posicao toPosicao() {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString() {
            return "" + Coluna + Linha;
        }
    }
}
