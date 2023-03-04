using System;

class Program
{
    static void Main()
    {
        while(true)
        {
            int senha = Convert.ToInt32(Console.ReadLine());
            if(senha != 2002)
                Console.WriteLine("Senha Invalida");
            else
            {
                Console.WriteLine("Acesso Permitido");
                break;
            }
        }
    }
}