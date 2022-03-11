using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    class EmployeeReportGeneration
    {
        public void GenerateReport(Employee employee)
        {
            Console.WriteLine("Report of the employee passed in the function is generated");
            Console.WriteLine("Employee name: "+employee.Employee_Name);
        }
    }
}
