using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida al usuario el radio de un círculo y que calcule y muestre el área y el perímetro (el área de un círculo es PI por radio cuadrado y el perímetro es 2 por radio por PI). PI es = 3.141593

            const Double PI = 3.141593;
            Console.WriteLine("Por favor, introduzca el radio del circulo");
            String num1Intro;
            int num1;
            num1Intro = Console.ReadLine();
            num1 = Int32.Parse(num1Intro);

            Double area;
            area = PI * (num1 * num1);
            Console.WriteLine($"El area del circulo es {area}");

            Double perim;
            perim = 2 * num1 * PI;
            Console.WriteLine($"El perimetro del circulo es {perim}");
        }
    }
}
