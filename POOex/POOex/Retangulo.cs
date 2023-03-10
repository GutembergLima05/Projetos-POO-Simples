using System.Globalization;

namespace POOex
{
    internal class Retangulo
    {
        public double Altura, Largura;

        public double Area()
        {
            return  Altura * Largura;
        }

        public double Perimetro()
        {
           return 2 * Altura + 2 * Largura;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }
    }
}
