using System;

class Program
{
    static void Main(string[] args)
    {
        double salario = Convert.ToDouble(Console.ReadLine());
        double reajuste;

        if(salario >= 0 && salario <= 400.00)
            reajuste = 0.15;

        else if(salario > 400.00 && salario <= 800.00)
            reajuste = 0.12;
        
        else if(salario > 800.00 && salario <= 1200.00)
            reajuste = 0.10;
        
        else if(salario > 1200.00 && salario <= 2000.00)
            reajuste = 0.07;

        else
            reajuste = 0.04;
        
        Console.WriteLine("Novo salario: " + (salario + salario * reajuste).ToString("F2"));
        Console.WriteLine("Reajuste ganho: " + (salario * reajuste).ToString("F2"));
        Console.WriteLine("Em percentual: " + (int)(reajuste * 100) + " %");
    }
}