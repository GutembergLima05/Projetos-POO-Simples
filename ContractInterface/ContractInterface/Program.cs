﻿using System.Globalization;
using ContractInterface.Entities;
using ContractInterface.Service;    

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double amount = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, amount);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, months);

            Console.WriteLine();
            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}