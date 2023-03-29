using System;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int a = 1;
        for(int i = 0; i < n; i++) {
            for(int j = 1; j < 5;  j++) {
                if(j % 4 == 0) {
                    Console.WriteLine("PUM");
                }
                else {
                    Console.Write($"{a} ");
                }
                a++;
            }
        }
    }
}