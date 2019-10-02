using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida un número de 3 dígitos y que muestre en pantalla el resultado de sumarlos.

            Console.WriteLine("Introduce un numero de tres digitos");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = num % 10;
            int num2 = num % 100;
            num2 /= 10;
            int num3 = num / 100;
            Console.WriteLine($"El resultado de la suma de los tres digitos es {num1 + num2 + num3}");



        }
    }
}
