﻿using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args) {
        string[] texto = Console.ReadLine().Split();
        double x = double.Parse(texto[0]);
        double y = double.Parse(texto[1]);

        if (x > 0 && y > 0)
            Console.WriteLine("Q1");
        else if (x < 0 && y > 0)
            Console.WriteLine("Q2");
        else if (x < 0 && y < 0)
            Console.WriteLine("Q3");
        else if (x > 0 && y < 0)
            Console.WriteLine("Q4");
        else if (x == 0 && y == 0)
            Console.WriteLine("Origem");
        else if (x == 0 && y != 0)
            Console.WriteLine("Eixo Y");
        else if (x != 0 && y == 0)
            Console.WriteLine("Eixo X");
    }
}