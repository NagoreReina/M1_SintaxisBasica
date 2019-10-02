using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que muestre el resultado de las siguientes operaciones:
            //-5 + 8 * 6
            //(55 + 9) % 6
            //20 + -3 * 5 / 8
            //5 + 15 / 3 * 2 - 8 % 3


            int op1;
            op1 = -5 + 8 * 6;
            Console.WriteLine("-5 + 8 * 6 = " + op1);
            double op2;
            op2 = (55 + 9) % 6;
            Console.WriteLine("(55 + 9) % 6 = " + op2);
            double op3;
            op3 = 20 + -3 * 5 / 8;
            Console.WriteLine("20 + -3 * 5 / 8 = " + op3);
            double op4;
            op4 = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("5 + 15 / 3 * 2 - 8 % 3 = " + op4);

        }
    }
}
