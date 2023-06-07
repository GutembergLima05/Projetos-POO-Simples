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
            
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Person pf in list)
            {
                Console.WriteLine(pf.Name + ": $ " + pf.Tax().ToString("F2", CultureInfo.InvariantCulture));            

            }

            Console.WriteLine();
            double sum = 0.0;
            foreach (Person pf in list) {
                sum += pf.Total;
            }
            Console.Write("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}