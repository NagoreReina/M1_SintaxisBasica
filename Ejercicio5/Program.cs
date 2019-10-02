using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida dos números al usuario y muestre el resultado de multiplicar los dos

            Console.WriteLine("Por favor, introduzca el primer valor a multiplicar");
            String num1Intro;
            int num1;
            num1Intro = Console.ReadLine();
            num1 = Int32.Parse(num1Intro);
            Console.WriteLine("Por favor, introduzca el SEGUNDO valor a multiplicar");
            String num2Intro;
            int num2;
            num2Intro = Console.ReadLine();
            num2 = Int32.Parse(num2Intro);
            Console.WriteLine("El resultado es " + num1 * num2);
        }
    }
}
