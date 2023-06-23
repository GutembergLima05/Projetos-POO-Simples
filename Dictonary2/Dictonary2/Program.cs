using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                Dictionary<string, int> dictonary = new Dictionary<string, int>();
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidate = line[0];
                        int votes = int.Parse(line[1]);
                        if (dictonary.ContainsKey(candidate))
                        {
                            dictonary[candidate] += votes;
                        } else
                        {
                            dictonary[candidate] = votes;
                        }
                    }

                    foreach (var item in dictonary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } 
    }
}