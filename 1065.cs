using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;

        for(int i = 0; i < 5; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
                count += 1;
        }
        Console.WriteLine(count + " valores pares");
    }
}