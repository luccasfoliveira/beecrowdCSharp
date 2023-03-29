using System;

class Program
{
    static void Main(string[] args) {
        int inter = 0, gremio = 0, empate = 0;
        while(true) {
            string[] texto = Console.ReadLine().Split();
            int A = int.Parse(texto[0]);
            int B = int.Parse(texto[1]);

            if(A > B) {
                inter++;
            }
            else if(B > A) {
                gremio++;
            }
            else {
                empate++;
            }
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            int resp = int.Parse(Console.ReadLine());
            if(resp == 2) {
                break;
            }
        }

        Console.WriteLine($"{inter + gremio + empate} grenais");
        Console.WriteLine($"Inter:{inter}");
        Console.WriteLine($"Gremio:{gremio}");
        Console.WriteLine($"Empates:{empate}");
        if(inter > gremio) {
            Console.WriteLine("Inter venceu mais");
        }
        else if(gremio > inter) {
            Console.WriteLine("Gremio venceu mais");
        }
        else {
            Console.WriteLine("Nao houve vencedor");
        }
    }
}