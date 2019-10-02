using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida un número al usuario y muestre la tabla de multiplicar hasta 10 de ese número
            Console.WriteLine("Por favor, introduzca el valor");
            String num1Intro;
            int num1;
            num1Intro = Console.ReadLine();
            num1 = Int32.Parse(num1Intro);
            Console.WriteLine(".....................");
            for (int i=0; i <11; i++)
            {
                //Console.WriteLine($"{num1} x {i} = {num1 * i} ");
               Console.WriteLine(num1 + " X " + i + " = " + (num1*i));
            }
        }
    }
}
