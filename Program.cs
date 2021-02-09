using System;
using System.Collections.Generic;
using Solid.Classes;
using Solid.Helpers.Notification;
using Solid.Helpers.Utils;
using Solid.Helpers.Utils.Enums;
using Solid.Interface;

namespace Solid
{
    class Program
    {
        // TO DO: Make a LoggerFactory
        // see https://refactoring.guru/pt-br/design-patterns/factory-method/
        static void Main(string[] args)
        {
            //SalaryTaxes();
            LoggerFactoryMethod();
        }

        static void SalaryTaxes()
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

        static void LoggerFactoryMethod()
        {
            var genericError = new Error()
            {
                Criticality = ErrorCriticalityLevelEnum.GenericError,
                Message = $"{ErrorCriticalityLevelEnum.GenericError.GetDescription()}."
            };

            var criticalError = new Error()
            {
                Criticality = ErrorCriticalityLevelEnum.CriticalError,
                Message = $"{ErrorCriticalityLevelEnum.CriticalError.GetDescription()}!!!"
            };

            var notificationHandler = new NotificationHandler();

            System.Console.Clear();
            System.Console.WriteLine("Test with Generic Error");
            System.Console.WriteLine("");
            var logger = notificationHandler.LoggerCreators[genericError.Criticality].Invoke();
            logger.LogError(genericError);
            System.Console.WriteLine("");

            System.Console.WriteLine("");
            System.Console.WriteLine("");

            System.Console.WriteLine("Test with Critical Error");
            System.Console.WriteLine("");
            logger = notificationHandler.LoggerCreators[criticalError.Criticality].Invoke();
            logger.LogError(criticalError);
            System.Console.WriteLine("");
            System.Console.WriteLine("");
        }
    }
}
