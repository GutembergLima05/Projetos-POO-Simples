using System.Globalization;
using TestPOO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Ap[] vet = new Ap[10];

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Ap { Email = email, Nome = nome};
                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }
            
        }
    }
}