using System;

class Program
{
    static void Main(string[] args) {
        while (true) {
            string[] texto = Console.ReadLine().Split();
            if (texto[0] == "0" || texto[1] == "0") {
                break;
            }

            int A = int.Parse(texto[0]);
            int B = int.Parse(texto[1]);

            if(A > 0 && B > 0) {
                Console.WriteLine("primeiro");
            }
            else if(A < 0 && B > 0) {
                Console.WriteLine("segundo");
            }
            else if(A < 0 && B < 0) {
                Console.WriteLine("terceiro");
            }
            else if(A > 0 && B < 0){
                Console.WriteLine("quarto");
            }
        }
    }
}