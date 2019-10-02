using System;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida un número de minutos y muestre cuantos años y días son.

            Console.WriteLine("Introduce los minutos que quieras convertir");
            double mins = Convert.ToDouble(Console.ReadLine());
            double days = mins / 1440;
            double years = days / 365;
            Console.WriteLine($"Los minutos que has introducido son {days} dias y {years} año(s)");
        }
    }
}
