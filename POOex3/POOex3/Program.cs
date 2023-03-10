using POOex3;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            
            if (aluno.NotaFinal() >= 60.00)
            {
                Console.WriteLine("APROVADO");
            } else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60.00 - aluno.NotaFinal()).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}