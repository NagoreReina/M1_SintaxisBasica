using System;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que calcule el resto de dividir dos números sin utilizar el operador de división de resto (%)

            Console.WriteLine("Los numeros elegidos han sido 10 y 6, efectuaremos 10/6");
            double divResult = 10.0 / 6.0;
            int divResultEnt = 10 / 6;
            double resultOfRest = divResult - divResultEnt;
            double finalResult = (resultOfRest * 6);
            Console.WriteLine($"El resto de esa division es {finalResult}");
        }
    }
}
