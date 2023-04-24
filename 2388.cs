using System;

class Program
{
    static void Main(string[] args)
    {
        short n = short.Parse(Console.ReadLine());
        int soma = 0;
        for (short i = 0; i < n; i++)
        {
            string[] txt = Console.ReadLine().Split();
            soma += short.Parse(txt[0]) * short.Parse(txt[1]);
        }
        Console.WriteLine(soma);
    }
}