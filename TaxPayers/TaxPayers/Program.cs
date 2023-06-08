using System.Globalization;
using System.Linq;
using TaxPayers.Entities;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;
                    list.Add(new PF(name, renda, health));
                } else if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employee = int.Parse(Console.ReadLine());
                    list.Add(new PJ(name, renda, employee));
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Person pf in list)
            {
                double tax = pf.Tax();
                Console.WriteLine(pf.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));            
                sum += tax;
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}