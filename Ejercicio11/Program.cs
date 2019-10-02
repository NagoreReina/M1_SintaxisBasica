using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida tres números al usuario y que calcule y muestre su media.

            Console.WriteLine("Por favor, introduce el PRIMER valor");
            String num1Intro;
            num1Intro = Console.ReadLine();
            double num1 = Convert.ToDouble(num1Intro);
            Console.WriteLine("Por favor, introduzca el SEGUNDO valor");
            String num2Intro;
            num2Intro = Console.ReadLine();
            double num2 = Convert.ToDouble(num2Intro);
            Console.WriteLine("Por favor, introduzca el TERCER valor");
            String num3Intro;
            num3Intro = Console.ReadLine();
            double num3 = Convert.ToDouble(num3Intro);
            Console.WriteLine($"La media de los valores introducidos es {(num1 + num2 + num3)/3}");
        }
    }
}
