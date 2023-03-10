using POOex2;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Fucionario f;
            f = new Fucionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Funcionário: " + f);

            Console.WriteLine();

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(aumento);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + f);
        }
    }
}