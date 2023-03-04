using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int qnt = int.Parse(Console.ReadLine());
        float salario = float.Parse(Console.ReadLine());

        Console.WriteLine($"NUMBER = {num}");
        Console.WriteLine("SALARY = U$ " + (qnt * salario).ToString("F2"));
    }
}