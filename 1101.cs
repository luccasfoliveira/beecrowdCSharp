using System;

class Program
{
    static void Main(string[] args) {
        while (true) {
            string[] texto = Console.ReadLine().Split(' ');

            int a = int.Parse(texto[0]);
            int b = int.Parse(texto[1]);

            if (a <= 0 || b <= 0)
                break;

            
            int maior = b, menor = a;
            if (a > b) {
                maior = a;
                menor = b;
            }

            int soma = 0;

            for (int i = menor; i <= maior; i++) {
                Console.Write(i + " ");
                soma += i;
            }
            Console.WriteLine("Sum=" + soma);
        }
    }
}