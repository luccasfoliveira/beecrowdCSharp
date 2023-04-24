using System;

class Program
{
    static void Main(string[] args)
    {
        ushort n = ushort.Parse(Console.ReadLine());
        string[] txt = Console.ReadLine().Split();
        ushort soma = 0;
        for (ushort i = 0; i < txt.Length; i++)
        {
            if (short.Parse(txt[i]) == 1)
            {
                soma++;
            }
        }
        Console.WriteLine(soma);
    }
}