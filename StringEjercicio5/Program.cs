using System;

namespace StringEjercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que dada una cadena identifique los caracteres del 5 al 10.

            string frase = "Esta es la frase que vamos a utilizar en este ejercicio";
            Console.WriteLine(frase);
            frase = frase.Substring(5, 5);
            Console.WriteLine(frase);
        }
    }
}
