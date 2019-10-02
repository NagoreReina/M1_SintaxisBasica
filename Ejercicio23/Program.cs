using System;

namespace Ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que genere un número aleatorio entre el 1 y el 100 (pista: hay que utilizar una función).

            Random num = new Random();
            Console.WriteLine($"El resultado es {num.Next(0,101)}");
        }
    }
}
