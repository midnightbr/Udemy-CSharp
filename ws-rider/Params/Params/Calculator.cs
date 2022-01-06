namespace Params {
    public class Calculator {
        public static int Sum(params int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }

        /**
         * Para poder utilizar o 'a' por referencia, basta adicionar o ref no método como o
         * exemplo abaixo. Fazendo assim, a variavel é obtida por referencia e não por valor.
         * Sendo assim, a variavel 'a' no programa principal sera alterado quando o método
         * Triple for executado.
         */
        public static void Triple(ref int x) {
            x = x * 3;
        }

        /**
         * O modificador out é similar ao ref (faz o parametro ser uma referencia para a variavel original),
         * mas não exige que a variavel original seja iniciada.
         */
        public static void TripleSecond(int origin, out int result) {
            result = origin * 3;
        }
    }
}
