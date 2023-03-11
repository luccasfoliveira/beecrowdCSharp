using System;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++) {
            string[] texto = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(texto[0]) / int.Parse(texto[1]) + int.Parse(texto[0]) % int.Parse(texto[1]));
        }
    }
}