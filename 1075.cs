using System;

class Program
{
    static void Main(string[] args)
    {
         int num = Convert.ToInt32(Console.ReadLine());
         for(int i = 2; i <= 10000; i++)
         {
            if(i % num == 2)
                Console.WriteLine(i);
         }
    }
}