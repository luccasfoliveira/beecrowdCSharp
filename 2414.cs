using System;

class Program
{
    static void Main(string[] args)
    {
        string[] txt = Console.ReadLine().Split();
        short maior = short.Parse(txt[0]);
        for (int i = 1; i < txt.Length; i++)
        {
            if (short.Parse(txt[i]) > maior)
            {
                maior = short.Parse(txt[i]);
            }
        }
        Console.WriteLine(maior);
    }
}