using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            bool primo = true;
            long num = Convert.ToInt64(Console.ReadLine());

            if ((num % 2 == 0 && num != 2) || num == 1)
                primo = false;
            else
            {
                for(int j = 3; j < (int)Math.Sqrt(num)+1; j += 2)
                {
                    if(num % j == 0)
                    {
                        primo = false;
                    }
                }
            }
            if(primo)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");
        }  
    }
}