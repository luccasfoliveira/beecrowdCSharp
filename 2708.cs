using System;

class Program
{
    static void Main(string[] args) {
        int count = 0, countQnt = 0;
        while (true) { 
            string[] texto = Console.ReadLine().Split();
            if (texto[0] == "ABEND") {
                break;
            }
            else if (texto[0] == "SALIDA") {
                count++;
                countQnt += int.Parse(texto[1]);
            }
            else {
                count--;
                countQnt -= int.Parse(texto[1]);
            }
        }
        Console.WriteLine(countQnt);
        Console.WriteLine(count);
    }
}