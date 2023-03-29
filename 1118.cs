using System;

class Program
{
    static void Main(string[] args) {
        while (true) {
            double N1 = 0, N2 = 0, media = 0;
            int resp = 0;
            while (true) {
                N1 = double.Parse(Console.ReadLine());
                if (N1 >= 0 && N1 <= 10) {
                    break;
                }
                Console.WriteLine("nota invalida");
            }

            while (true) {
                N2 = double.Parse(Console.ReadLine());
                if (N2 >= 0 && N2 <= 10) {
                    break;
                }
                Console.WriteLine("nota invalida");
            }

            media = (N1 + N2) / 2;
            Console.WriteLine($"media = {media:N2}");

            while (true) {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                resp = int.Parse(Console.ReadLine());
                if (resp == 1 || resp == 2) {
                    break;
                }
            }
            if (resp == 2) {
                break;
            }
        }
    }
}