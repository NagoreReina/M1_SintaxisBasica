using System;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida una distancia (en metros), y el tiempo tardado (como tres números: horas, minutos y segundos) y que muestre la velocidad en metros por segundo y kilómetros por hora.

            Console.WriteLine("Intruduce la distancia recorrida en metros");
            double dist = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ahora introduce las horas que has tardado (luego tendras que introducir los minutos y los segundos)");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ahora introduce los minutos que has tardado (sin contar las horas, puesto que ya las has introducido antes)");
            double mins = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por ultimo, introduce los segundos");
            double seconds = Convert.ToDouble(Console.ReadLine());

            seconds += (hours * 3600) + (mins * 60);
            hours = seconds / 3600;
            double kilometers = dist / 1000;

            Console.WriteLine($"La velocidad en Kilometros/Hora es de {kilometers/hours} km/h");
            Console.WriteLine($"La velocidad en metros/segundo es de {dist/seconds} m/s");

        }
    }
}
