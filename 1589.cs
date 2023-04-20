using System;

class Program
{
    static void Main(string[] args)
    {
        short n = short.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] txt = Console.ReadLine().Split();
            int A = int.Parse(txt[0]) + int.Parse(txt[1]);
            Console.WriteLine(A);
        }
    }
}