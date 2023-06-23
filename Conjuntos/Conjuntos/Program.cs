using System;
using System.IO;
using Conjuntos.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();


            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        //Outro metódo de usar classe sem o construtor 
                        set.Add(new LogRecord { Username = name, Instant = instant });
                    }
                    // Count usado para contagem de usuarios no hashset
                    Console.WriteLine("Total users: " + set.Count);
                }
            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}