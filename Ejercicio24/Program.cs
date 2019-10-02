using System;

namespace Ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida dos números y que muestre la suma, la resta, la multiplicación y la media.

            Console.WriteLine("Por favor, introduzca el primer valor");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor, introduzca el SEGUNDO valor");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El resultado de sumar los valores es " + (num1 + num2));
            Console.WriteLine("El resultado de multiplicar los valores es " + num1 * num2);
            Console.WriteLine("El resultado de restar los valores es " + (num1 - num2));
            Console.WriteLine("La media de los valores es " + ((num1 + num2) / 2));

        }
    }
}
