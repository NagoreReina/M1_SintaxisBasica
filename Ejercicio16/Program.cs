using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida al usuario un número y convierta el string a un int y lo muestre en pantalla.

            Console.WriteLine("Introduce un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero introducido es " + num);
        }
    }
}
