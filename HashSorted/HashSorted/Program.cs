using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using HashSorted.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Como funciona coleções Hash

            HashSet<Product> a1 = new HashSet<Product>();
            a1.Add(new Product("TV", 900.0));
            a1.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b1 = new HashSet<Point>();
            b1.Add(new Point(3, 4));
            b1.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(a1.Contains(prod));

            Point p1 = new Point(5, 10);
            Console.WriteLine(b1.Contains(p1));


            // "Não utiliza as classes"
            //Aula sobre HashSet e SortedSet

            Console.WriteLine();
            HashSet<string> set = new HashSet<string>();
            Console.WriteLine("HashSet:");
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Computer"));

            foreach (string p in set)
            {
                Console.WriteLine(p);

            }
            Console.WriteLine();

            SortedSet<int> a = new SortedSet<int>() { 10, 0, 2, 4, 5, 6, 8 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
            // union

            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            PrintCollection(c);
            PrintCollection(a);

            // Intersection 

            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            // Difference

            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);

        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection) {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}