using System;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        string[] texto = Console.ReadLine().Split();
        int countDois = 0, countTres = 0, countQuatro = 0, countCinco = 0;
        for (int i = 0; i < n; i++) {
            if (int.Parse(texto[i]) % 2 == 0) 
                countDois++;

            if (int.Parse(texto[i]) % 3 == 0) 
                countTres++;

            if (int.Parse(texto[i]) % 4 == 0) 
                countQuatro++;

            if (int.Parse(texto[i]) % 5 == 0 )
                countCinco++;
        }
        Console.WriteLine($"{countDois} Multiplo(s) de 2");
        Console.WriteLine($"{countTres} Multiplo(s) de 3");
        Console.WriteLine($"{countQuatro} Multiplo(s) de 4");
        Console.WriteLine($"{countCinco} Multiplo(s) de 5");
    }
}