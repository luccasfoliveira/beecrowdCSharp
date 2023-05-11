using System;

class Program
{
    static void Main(string[] args)
    {
        string[] txt = Console.ReadLine().Split();
        var A = int.Parse(txt[0]);
        var i = 1;
        while (int.Parse(txt[i]) <= 0)
        {
            i++;
        }
        var N = int.Parse(txt[i]);
        var soma = A;
        for (i = 1; i < N; i++)
        {
            soma += A + i;
        }
        Console.WriteLine(soma);
    }
}