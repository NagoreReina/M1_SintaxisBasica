using System;

namespace StringEjercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que escriba en mayúscula una frase en minúscula.

            string frase = "ESTA ES LA FRASE";
            Console.WriteLine(frase);
            frase = frase.ToLower();
            Console.WriteLine(frase);
        }
    }
}
