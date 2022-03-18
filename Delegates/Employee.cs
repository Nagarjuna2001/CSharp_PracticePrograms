using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class Employee
    {
        public Employee() { }
        public int ID { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }

        public static void PrintEmployeesEligibleForPromotion(List<Employee> EmployeeList, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in EmployeeList)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " is eligible for promotion.");
                }
            }
        }
    }
}
