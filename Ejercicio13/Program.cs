using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida dos variables, y después intercambie sus valores (si por ejemplo ponemos 8 en la variable a y 5 en la variable b, que al final del programa la variable a tenga el valor 5 y la variable b el valor 8).

            Console.WriteLine("Dale un valor a la variable num1");
            String num1Intro;
            int num1;
            num1Intro = Console.ReadLine();
            num1 = Int32.Parse(num1Intro);
            Console.WriteLine("Dale un valor a la variable num2");
            String num2Intro;
            int num2;
            num2Intro = Console.ReadLine();
            num2 = Int32.Parse(num2Intro);
            Console.WriteLine($"Has dicho que num1 es {num1} y num2 es {num2}");
            int saveNum;
            saveNum = num1;
            num1 = num2;
            num2 = saveNum;
            Console.WriteLine($"Tras efectuar el cambio num1 es {num1} y num2 es {num2}");

        }
    }
}
