using System;

class Program
{
    static void Main(string[] args)
    {
        string txt;
        while ((txt = Console.ReadLine()) != null)
        {
            byte num = byte.Parse(txt);
            switch (num)
            {
                case 0: Console.WriteLine("vai ter copa!"); break;
                default: Console.WriteLine("vai ter duas!"); break;
            }
        }
    }
}