using System;

class Program
{
    static void Main(string[] args) {
        string[] texto = Console.ReadLine().Split();
        double preco;

        switch (int.Parse(texto[0]))
        {
            case 1: preco = 4.0; break;
            case 2: preco = 4.5; break;
            case 3: preco = 5.0; break;
            case 4: preco = 2.0; break;
            default: preco = 1.5; break;
        }

        Console.WriteLine($"Total: R$ {int.Parse(texto[1]) * preco:N2}");
    }
}