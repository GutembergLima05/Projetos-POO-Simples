using ListPOO;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Funcionário #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario (id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Entre com o id do funcionário que terá aumento no salário : ");
            int searchId = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == searchId);

            if (func != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse id não existe!");
            }


            Console.WriteLine();
            Console.WriteLine("Lista atualizada de Funcionários:");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}