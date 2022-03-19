using System;

namespace AbstractClass
{
    public class AbstractClassExercise
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fulltimeEmployee = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "Steve",
                LastName = "smith",
                AnnualSalary = 60000
            };
            Console.WriteLine(fulltimeEmployee.GetFullName());
            Console.WriteLine(fulltimeEmployee.GetMonthlySalary());

            Console.WriteLine("----------------------------------------");

            ContractEmployee contractEmployee = new ContractEmployee()
            {
                ID = 102,
                FirstName = "George",
                LastName = "louis",
                HourlyPay = 200,
                TotalHoursWorked = 40
            };
            Console.WriteLine(contractEmployee.GetFullName());
            Console.WriteLine(contractEmployee.GetMonthlySalary());
        }
    }
}
