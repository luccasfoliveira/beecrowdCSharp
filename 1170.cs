using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            double kg = Convert.ToDouble(Console.ReadLine());
            int dias = 0;
            while (kg > 1)
            {
                kg /= 2;
                dias ++;
            }
        Console.WriteLine($"{dias} dias");
        }
    }
}