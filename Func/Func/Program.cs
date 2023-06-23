using Func.Entities;
using System;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Expressão Func com classe
            //Func<Product, string> func = NameUpper;

            //Expressão Lambda
            //Func<Product, string> func = p => p.Name.ToUpper();

            //Expressão Lambda Inline 
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        //Expressão Func com classe

       //   static string NameUpper(Product p)
       //    {
       //     return p.Name.ToUpper();
       //    }
    }
}