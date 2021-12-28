namespace ExProp_24 {
    public class ConversorDeMoeda {
        public static double Iof = 0.06;
        
        public static double Conversao(double cotacao, double quantidade) {
            // double imposto = quantidade * Iof;
            double total = quantidade + (quantidade * Iof);
            double conversao = total * cotacao;
            return conversao;
        }
    }
}
