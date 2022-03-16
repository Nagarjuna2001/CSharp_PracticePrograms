using System;
using System.Collections.Generic;

//Code to print all the employees who are eligible to get promoted based on the no. of years of their working experience

namespace Delegates
{
    public delegate bool IsPromotable(Employee employee);
    public class EmployeesPromotion
    {
        static void Main(string[] args)
        {
            List<Employee> ListOfEmployees = new List<Employee>();

            ListOfEmployees.Add(new Employee() { ID = 101, Name = "Arjun", Experience = 5 });
            ListOfEmployees.Add(new Employee() { ID = 102, Name = "Varun", Experience = 4 });
            ListOfEmployees.Add(new Employee() { ID = 103, Name = "Vishal", Experience = 7 });

            IsPromotable isPromotable = new IsPromotable(CheckForPromotionEligibility);

            Employee.PrintEmployeesEligibleForPromotion(ListOfEmployees, isPromotable);
        }

        public static bool CheckForPromotionEligibility(Employee employee)
        {
            if (employee.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}