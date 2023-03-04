using System;

class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i = 2; i <= num; i += 2)
        {
            Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
        }
    }
}