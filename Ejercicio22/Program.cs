using System;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que convierta los segundos a horas, minutos y segundos.

            Console.WriteLine("introduce los segundos");
            double seconds = Convert.ToDouble(Console.ReadLine());
            int hours = Convert.ToInt32(seconds / 3600);
            double restSeconds = seconds % 3600;
            int minutes = Convert.ToInt32(restSeconds / 60);
            restSeconds = restSeconds % 60;


            Console.WriteLine($"Has introducido {seconds} segundos que son: {hours} horas {minutes} minutos y {restSeconds} segundos");
        }
    }
}
