using System;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        for(int i = 1; i <= n; i++) {
            Console.WriteLine($"{Potencia(i, 1)} {Potencia(i, 2)} {Potencia(i, 3)}");
        }
    }

    static int Potencia(int n, int exp) {
        int x = n;
        for(int i = 1; i < exp; i++) {
            n *= x;
        }
        return n;
    }
}