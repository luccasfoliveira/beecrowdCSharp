﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i = num; i < (num + 12); i++)
        {
            if(i % 2 != 0)
                Console.WriteLine(i);
        }
    }
}