using ExConjuntos.Entities;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> log = new HashSet<LogRecord>();
            Console.Write("How many students for course A?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                log.Add(new LogRecord(value));
            }
            Console.Write("How many students for course b?");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                log.Add(new LogRecord(value));
            }
            Console.Write("How many students for course C?");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                log.Add(new LogRecord(value));
            }
            Console.WriteLine("Total students: " + log.Count);
        }
    }
}