using System;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que le pida al usuario un número de pulgadas y lo convierta a metros (una pulgada son 0.0254 metros)

            Console.WriteLine("Introduce tu valor en pulgadas");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Tu valor en metros es de {num* 0.0254}");
        }
    }
}
