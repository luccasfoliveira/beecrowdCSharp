using System;

class Program
{
    static void Main(string[] args) {
        int m = int.Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = m - (a + b);
        int aux = 0;

        if (a < b) {
            aux = a;
            a = b;
            b = aux;
        }
        if(a < c) {
            aux = a;
            a = c;
            c = aux;
        }
        Console.WriteLine(a);
    }
}