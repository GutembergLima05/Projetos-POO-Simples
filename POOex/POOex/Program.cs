using POOex;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x;
                x = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            x.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + x.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + x.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + x.Diagonal().ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}