using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        for(int i = 0; i < 6; i++)
        {
            double num = Convert.ToDouble(Console.ReadLine());
            if(num > 0)
                count ++;
        }
        Console.WriteLine(count + " valores positivos");
    }
}