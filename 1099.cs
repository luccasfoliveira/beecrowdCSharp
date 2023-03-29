using System;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            string[] texto = Console.ReadLine().Split();
            int somaImpar = 0;
            int A = int.Parse(texto[0]);
            int B = int.Parse(texto[1]);

            if (A > B) {
                int AUX = A;
                A = B;
                B = AUX;
            }

            for (int j = A+1; j < B; j++) {
                if (j % 2 != 0) {
                    somaImpar += j;
                }
            }
            Console.WriteLine(somaImpar);
        }
    }
}
