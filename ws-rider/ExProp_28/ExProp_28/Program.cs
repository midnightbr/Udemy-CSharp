#nullable enable
using System;

namespace ExProp_28 {
    class Program {
        static void Main(string[] args) {
            int x = 0;
            int y = 0;
            Console.Write("Enter the size of the matrix: ");
            if (x == 0) {
                string[] array = Console.ReadLine().Split(' ');
                x = int.Parse(array[0]);
                y = int.Parse(array[1]);
            }
            int[,] matrix = new int[x, y];

            Console.WriteLine("Enter the values: ");
            for (int i = 0; i < x; i++) {
                string[] array = Console.ReadLine().Split(' ');
                for (int f = 0; f < y; f++) {
                    matrix[i, f] = int.Parse(array[f]);
                }
            }

            Console.Write("Enter the desired value: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++) {
                for (int j = 0; j < y; j++) {
                    if (matrix[i, j] == number) {
                        Console.WriteLine("Positio {0}, {1}", i, j);
                        if ((j - 1) >= 0) {
                            Console.WriteLine("Left: {0}", matrix[i, (j - 1)]);    
                        }
                        
                        if ((i - 1) >= 0) {
                            Console.WriteLine("Up: {0}", matrix[(i - 1), j]);
                        }
                        
                        if ((j + 1) < y) {
                            Console.WriteLine("Right: {0}", matrix[i, (j + 1)]);    
                        }
                        
                        if ((i + 1) < x) {
                            Console.WriteLine("Down: {0}", matrix[(i + 1), j]);    
                        }
                        
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matrix:");
            for(int i = 0; i < x; i++) {
                Console.Write("|");
                for (int j = 0; j < y; j++) {
                    Console.Write(" " + matrix[i, j] + " |");
                }
                Console.WriteLine();
            }
        }
    }
}
