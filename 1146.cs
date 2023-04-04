using System;

class Program
{
    static void Main(string[] args) {
        while (true) {
            int N = int.Parse(Console.ReadLine());
            if(N == 0) {
                break;
            }
            for(int i = 1; i <= N; i++) {
                if(i == N) {
                    Console.WriteLine($"{i}");
                }
                else {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}