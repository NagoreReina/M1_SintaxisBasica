using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida al usuario la anchura y altura de un rectángulo y que calcule y muestre su área y su perímetro (el área es la altura por la anchura y el perímetro es 2 por la suma de la altura y la anchura).

            Console.WriteLine("Por favor, introduce la ANCHURA");
            String anchIntro;
            int anch;
            anchIntro = Console.ReadLine();
            anch = Int32.Parse(anchIntro);
            Console.WriteLine("Por favor, introduce la ALTURA");
            String altIntro;
            int alt;
            altIntro = Console.ReadLine();
            alt = Int32.Parse(altIntro);
            Console.WriteLine($"El Area del Rectangulo es {anch*alt}");
            Console.WriteLine($"El Perimetro del Rectangulo es {2*(anch+alt)}");
        }
    }
}
