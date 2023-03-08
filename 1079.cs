using System;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++) {
            string[] texto = Console.ReadLine().Split();
            double n1 = double.Parse(texto[0]) * 2;
            double n2 = double.Parse(texto[1]) * 3;
            double n3 = double.Parse(texto[2]) * 5;

            double media = (n1 + n2 + n3) / 10;
            Console.WriteLine($"{media:N1}");
        }
    }
}