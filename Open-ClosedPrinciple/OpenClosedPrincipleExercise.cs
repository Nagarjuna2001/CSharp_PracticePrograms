using System;

namespace OpenClosedPrinciple
{
    public class OpenClosedPrincipleExercise
    {
        static void Main(string[] args)
        {
            Employee permanent_employee = new PermanentEmployee(101, "Mark");
            Console.WriteLine("Employee {0} Bonus : {1}", permanent_employee.ToString(), permanent_employee.CalculateBonus(150000));

            Employee temporary_employee = new TemporaryEmployee(102, "Steve");
            Console.WriteLine("Employee {0} Bonus : {1}", temporary_employee.ToString(), temporary_employee.CalculateBonus(100000));
        }
    }
}
