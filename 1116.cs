using System;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            string[] texto = Console.ReadLine().Split();
            double A = double.Parse(texto[0]);
            double B = double.Parse(texto[1]);

            if(B == 0) {
                Console.WriteLine("divisao impossivel");
            }
            else {
                double resultado = A / B;
                Console.WriteLine($"{resultado:N1}");
            }
        }
    }
}