using System;

class Program
{
    static void Main(string[] args)
    {
         int num = Convert.ToInt32(Console.ReadLine());
         for(int i = 1; i <= 10; i++)
            Console.WriteLine($"{i} x {num} = {num * i}");
    }
}