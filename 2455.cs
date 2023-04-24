using System;

class Program
{
    static void Main(string[] args)
    {
        string[] txt = Console.ReadLine().Split();
        if (ushort.Parse(txt[0]) * ushort.Parse(txt[1]) == ushort.Parse(txt[2]) * ushort.Parse(txt[3]))
        {
            Console.WriteLine(0);
        }
        else if (ushort.Parse(txt[0]) * ushort.Parse(txt[1]) < ushort.Parse(txt[2]) * ushort.Parse(txt[3]))
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(-1);
        }
    }
}