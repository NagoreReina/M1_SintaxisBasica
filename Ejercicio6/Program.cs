using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida dos números al usuario y muestre el resultado de sumarlos, multiplicarlos, restarlos, dividirlos y el resto de la división

            Console.WriteLine("Por favor, introduzca el primer valor");
            String num1Intro;
            int num1;
            num1Intro = Console.ReadLine();
            num1 = Int32.Parse(num1Intro);
            Console.WriteLine("Por favor, introduzca el SEGUNDO valor");
            String num2Intro;
            int num2;
            num2Intro = Console.ReadLine();
            num2 = Int32.Parse(num2Intro);
            Console.WriteLine("El resultado de sumar los valores es " + (num1 + num2));
            Console.WriteLine("El resultado de multiplicar los valores es " + num1 * num2);
            Console.WriteLine("El resultado de restar los valores es " + (num1 - num2));
            Console.WriteLine("El resultado de dividir los valores es " + (num1 / num2));
            Console.WriteLine("El resto de dividir los valores es " + (num1 % num2));
        }
    }
}
