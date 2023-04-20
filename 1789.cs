using System;

class Program
{
    static void Main(string[] args)
    {

        string subtxt;
        while ((subtxt = Console.ReadLine()) != null)
        {
            string[] txt = subtxt.Split();
            int count = int.Parse(txt[0]);
            for (int i = 1; i < txt.Length; i++)
            {
                if (int.Parse(txt[i]) > count)
                {
                    count = int.Parse(txt[i]);
                    if (count == 20)
                    {
                        Console.WriteLine(3);
                        break;
                    }
                }
            }
            if (count < 10)
            {
                Console.WriteLine(1);
            }
            else if (count < 20)
            {
                Console.WriteLine(2);
            }
        }
    }
}