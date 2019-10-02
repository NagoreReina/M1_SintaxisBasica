using System;

namespace StringEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que cambie a minúsculas una frase en mayúsculas.

            string frase = "esta es la frase";
            Console.WriteLine(frase);
            frase = frase.ToUpper();
            Console.WriteLine(frase);
        }
    }
}
