using System;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            string[] texto = Console.ReadLine().Split();
            int A = int.Parse(texto[0]);
            int B = int.Parse(texto[1]);

            if (A % Math.Pow(10, texto[1].Length) == B)
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");
        }
    }
}