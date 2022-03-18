using System;

namespace SalaryCalculatorForTesting
{
    public class SalaryCalculator
    {
        public SalaryCalculator() { }

        const int HoursInYear = 2080;

        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            return hourlyWage * HoursInYear;
        }

        public decimal GetHourlyWage(int annualSalary)
        {
            return annualSalary / HoursInYear;
        }

        public decimal GetMonthlySalary(decimal hourlyWage)
        {
            decimal salaryPerYear = GetAnnualSalary(hourlyWage);
            return salaryPerYear / 12;
        }
    }
}
