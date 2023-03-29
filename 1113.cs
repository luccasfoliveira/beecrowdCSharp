using System;

class Program
{
    static void Main(string[] args) {
        while (true) {
            string[] texto = Console.ReadLine().Split();
            if (texto[0] == texto[1]) {
                break;
            }
            int A = int.Parse(texto[0]);
            int B = int.Parse(texto[1]);

            if (A > B) {
                Console.WriteLine("Decrescente");
            }
            else {
                Console.WriteLine("Crescente");
            }
        }
    }
}
