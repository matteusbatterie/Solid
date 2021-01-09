using System;
using System.Collections.Generic;
using Solid.Classes;
using Solid.Helpers;
using Solid.Interface;

namespace Solid
{
    class Program
    {
        // TO DO: Make a LoggerFactory
        // see https://refactoring.guru/pt-br/design-patterns/factory-method/
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your salary:");

            var salaryInputValue = Convert.ToDecimal(Console.ReadLine().Replace(".", ","));
            var salary = new Salary(salaryInputValue);

            // TEMPORÁRIO: Alíquotas implementadas na construtora
            var taxes = new List<ITax>()
            {
                new INSS(),
                new IR()
            };

            salary.ApplyTaxes(taxes);

            Console.WriteLine($"Your salary, applying taxes discounts, is: {salary.NetSalary.ToCurrencyString()}");
        }
    }
}
