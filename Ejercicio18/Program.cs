using System;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida la temperatura en celsius y te la calcule en fahrenheit.
            Console.WriteLine("Introduce la temperatua en grados Cº para efectual el cambio a Fº");
            double temperature = Convert.ToDouble(Console.ReadLine());
            temperature = (temperature * 1.8) + 32;
            Console.WriteLine($"La temperatura introducida es {temperature}ºF");
        }
    }
}
