using System;

namespace StringEjercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que te calcule la largura de un string que pides por consola.

            Console.WriteLine("Introduce tu frase");
            string frase = Console.ReadLine();
            int larguraFrase = frase.Length;
            Console.WriteLine($"Tu frase tiene un total de {larguraFrase} caracteres");
        }
    }
}
