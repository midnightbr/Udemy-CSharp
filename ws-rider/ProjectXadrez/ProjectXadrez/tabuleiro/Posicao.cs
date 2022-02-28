namespace tabuleiro {
    public class Posicao {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna) {
            Linha = linha;
            Coluna = coluna;
        }

        /*
         * Criado para poder auxiliar dentro de cada peça, facilitando assim a obtenção das posições
         * das pessoas, com apenas uma linha de comando.
         */
        public void definirValores(int linha, int coluna) {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString() {
            return Linha + ", " + Coluna;
        }
    }
}
