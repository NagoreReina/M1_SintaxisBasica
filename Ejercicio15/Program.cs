using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida al usuario un dígito (n) y calcule y muestre el valor de n+nn+nnn. Por ejemplo si el usuario introduce 5 el programa calcularía 5 + 55 + 555

            Console.WriteLine("Introduce un numero de un digito");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = num + (num * 10 + num) + (num * 100 + num * 10 + num);
            Console.WriteLine($"Hemos efectuado la siguiente operacion {num} + {num}{num} + {num}{num}{num} y el resultado es {result}");
        }
    }
}
