using System;

namespace SingleResponsibilityPrinciple
{
    public class SingleResponsibilityPrincipleExercise
    {
        public static void Main(String[] args)
        {
            Employee employee = new Employee();
            employee.Employee_Id = 100;
            employee.Employee_Name = "Mark";
            employee.Employee_Salary = 10000;

            EmployeeReportGeneration EmployeeReport = new EmployeeReportGeneration();
            EmployeeReport.GenerateReport(employee);
        }


    }
}
