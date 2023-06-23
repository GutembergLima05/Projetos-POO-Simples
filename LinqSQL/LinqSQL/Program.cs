using System.IO;
using LinqSQL.Entities;
using System.Globalization;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                   string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    string email = line[1];
                    double price = double.Parse(line[2], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price, email));

                }
            }

            var max = list.Where(p => p.Price > salary).Select(p => p.Email);
            Console.WriteLine("Email of people whose salary is more than 2000.00: ");
                foreach (string email in max)
            {
                Console.WriteLine(email);
            }
            var sum = list.Where(p => p.Name[0] == 'M').Sum(p => p.Price);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum);

        }
    }
}