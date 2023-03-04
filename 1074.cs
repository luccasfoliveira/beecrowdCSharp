using System;

class Program
{
    static void Main(string[] args)
    {
         int num = Convert.ToInt32(Console.ReadLine());
         for(int i = 0; i < num; i++)
         {
            int n = Convert.ToInt32(Console.ReadLine());

            if(n % 2 == 0 && n != 0)
                if(n > 0)
                    Console.WriteLine("EVEN POSITIVE");
                else
                    Console.WriteLine("EVEN NEGATIVE");
            else if(n % 2 != 0)
                if(n > 0)
                    Console.WriteLine("ODD POSITIVE");
                else
                    Console.WriteLine("ODD NEGATIVE");
            else
                Console.WriteLine("NULL");
         }  
    }
}