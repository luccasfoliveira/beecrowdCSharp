using System;

class Program
{
    static void Main(string[] args)
    {
        int T = byte.Parse(Console.ReadLine());
        for (byte i = 0; i < T; i++)
        {
            int soma = 1, x = 1;
            int n = int.Parse(Console.ReadLine());
            while (x < n)
            {
                soma += Potencia(2, x);
            }
            Console.WriteLine(soma);
        }
    }
    static int Potencia(int numero, int expoente)
    {
        int num = numero;
        for (byte i = 1; i < expoente; i++)
        {
            num *= numero;
        }
        return num;
    }
}