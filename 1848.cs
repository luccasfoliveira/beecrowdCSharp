using System;

class Program
{
    static void Main(string[] args) {

        int countadorGrito = 0, contador = 0;
        while(true) {

            string grito = Console.ReadLine();

            if(grito == "caw caw") {

                Console.WriteLine(contador);
                countadorGrito++;

                if(countadorGrito == 3)
                    break;

                contador = 0;
            }
            else 
                contador += contadorPiscada(grito);
        }
    }
    static int contadorPiscada(string texto) {
        int contador = 0;
        for(int i = 2; i > -1; i--) {
            if (texto[2-i] == '*')
                contador += potenciaDois(i);
        }
        return contador;
    }

    static int potenciaDois(int exp) {
        int valor = 1;
        for(int i = 1; i <= exp; i++) 
            valor *= 2;    
        return valor;
    }
}
