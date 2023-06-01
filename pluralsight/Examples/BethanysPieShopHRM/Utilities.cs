using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Utilities
    {
        public static void UsingOptionalParameter()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;

            int yearlyWageForEmployee1 = CalculateYearlyWageWithOptionals(monthlyWage1, months1);

            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}");
        }
        public static int CalculateYearlyWageWithOptionals(int monthlyWage, int numberOfMonthsWorked, int bonus = 5)
        {
            Console.WriteLine($"The Yearly wage: {monthlyWage + numberOfMonthsWorked + bonus}");

            return monthlyWage + numberOfMonthsWorked + bonus;
        }
        
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            int local = 100;

            Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");

            // lets add a bonus month
            if (numberOfMonthsWorked == 12)
            {
                return monthlyWage * (numberOfMonthsWorked + 1);
            }

            return monthlyWage * numberOfMonthsWorked;
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            int local = 150;
            
            Console.WriteLine($"The Yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");

            //// lets add a bonus month
            //if (numberOfMonthsWorked == 12)
            //{
            //    return monthlyWage * (numberOfMonthsWorked + 1);
            //}

            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        {
            Console.WriteLine($"The Yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");

            //// lets add a bonus month
            //if (numberOfMonthsWorked == 12)
            //{
            //    return monthlyWage * (numberOfMonthsWorked + 1);
            //}

            return monthlyWage * numberOfMonthsWorked + bonus;
        }
    }
}
