using System;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine()); // lê o número de casos de teste

        int totalCobaias = 0;
        int totalRatos = 0;
        int totalSapos = 0;
        int totalCoelhos = 0;

        for (int i = 0; i < n; i++) {
            string[] entrada = Console.ReadLine().Split(' '); // lê a quantidade e o tipo de cobaia
            int quantia = int.Parse(entrada[0]);
            char tipo = char.Parse(entrada[1]);

            totalCobaias += quantia;

            switch (tipo) {
                case 'R':
                    totalRatos += quantia;
                    break;
                case 'S':
                    totalSapos += quantia;
                    break;
                case 'C':
                    totalCoelhos += quantia;
                    break;
            }
        }

        double percRatos = (double)totalRatos / totalCobaias * 100.0;
        double percSapos = (double)totalSapos / totalCobaias * 100.0;
        double percCoelhos = (double)totalCoelhos / totalCobaias * 100.0;

        Console.WriteLine("Total: " + totalCobaias + " cobaias");
        Console.WriteLine("Total de coelhos: " + totalCoelhos);
        Console.WriteLine("Total de ratos: " + totalRatos);
        Console.WriteLine("Total de sapos: " + totalSapos);
        Console.WriteLine("Percentual de coelhos: " + percCoelhos.ToString("F2") + " %");
        Console.WriteLine("Percentual de ratos: " + percRatos.ToString("F2") + " %");
        Console.WriteLine("Percentual de sapos: " + percSapos.ToString("F2") + " %");
    }
}
