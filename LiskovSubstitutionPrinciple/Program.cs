using LiskovSubstitutionPrinciple.Interfaces;
using System;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee permanent_employee = new PermanentEmployee(101, "Mark");
            Employee temporary_employee = new TemporaryEmployee(102, "Steve");


            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(permanent_employee);
            EmployeeList.Add(temporary_employee);

            Console.WriteLine("List of employees who are eligible for bonus");

            foreach (Employee employee in EmployeeList)
            {
                Console.WriteLine("Employee {0} Bonus : {1}", employee.ToString(), employee.CalculateBonus(100000));
            }

            Console.WriteLine("List of employees and their MinimumSalaries");

            List<IEmployee> AllEmployeeList = new List<IEmployee>();

            AllEmployeeList.Add(new PermanentEmployee(101, "Mark"));
            AllEmployeeList.Add(new TemporaryEmployee(102, "Steve"));
            AllEmployeeList.Add(new ContractEmployee(103, "Smith"));

            foreach(var employee in AllEmployeeList)
            {
                Console.WriteLine("Employee {0} MinSalary : {1}", employee.ToString(), employee.GetMinimumSalary());
            }

        }
    }
}
