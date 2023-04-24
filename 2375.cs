using System;

class Program
{
    static void Main(string[] args)
    {
        ushort n = ushort.Parse(Console.ReadLine());
        string[] txt = Console.ReadLine().Split();
        if (ushort.Parse(txt[0]) < n || ushort.Parse(txt[1]) < n || ushort.Parse(txt[2]) < n)
        {
            Console.WriteLine('N');
        }
        else
        {
            Console.WriteLine('S');
        }
    }
}