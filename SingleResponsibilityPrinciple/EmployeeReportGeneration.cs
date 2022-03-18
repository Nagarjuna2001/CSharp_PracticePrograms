using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class EmployeeReportGeneration
    {
        public EmployeeReportGeneration() { }

        public void GenerateReport(Employee employee)
        {
            try 
            {
                if (employee == null) throw new NullReferenceException();
                Console.WriteLine("Report of the employee passed in the function is generated");
                Console.WriteLine("Employee name: "+employee.Employee_Name);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
