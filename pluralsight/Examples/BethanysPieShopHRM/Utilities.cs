﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Utilities
    {
        public static void ParsingString()
        {
            Console.Write("Enter the wage ");
            string wage = Console.ReadLine();

            //int wageValue = int.Parse(wage);
            //Console.WriteLine(wageValue);

            int wageValue;

            if(int.TryParse(wage, out wageValue))
            {
                Console.WriteLine("Parsing succeed " + wageValue);
            }
            else
            {
                Console.WriteLine("Parsing failed");
            }

            string hireDateString = "12/12/2022";
            DateTime hireDate = DateTime.Parse(hireDateString);
            Console.WriteLine("Parsed date: " + hireDate);
        }
        public static void UsingStringEuality()
        {
            string name1 = "Bethany";
            string name2 = "BETHANY";

            Console.WriteLine("Are both names equal? " + (name1 == name2));
            Console.WriteLine("Is name equal to Bethany? " + (name1 == "bethany"));
            Console.WriteLine("Is name equal to BETHANY? " + name2.Equals("BETHANY"));
            Console.WriteLine("Is lower case name is equal to bethany? " + (name1.ToLower() == "bethany"));
        }
        public static void UsingEscapeCharacter()
        {
            string firstName = "Bethany";
            string lastName = "Smith";

            string displayName = $"Welcome!\n{firstName}\t{lastName}";
            Console.WriteLine(displayName);

            string filePath = @"C:\data\employeelist.xlsx";
            Console.WriteLine(filePath);

            string marketingTagLine = "Baking the best \"pies\" ever";
            Console.WriteLine(marketingTagLine);
        }
        public static void ManifulatingString()
        {
            string firstName = "Bethany";
            string lastName = "Smith";

            // string concatination
            string fullName = firstName + " " + lastName;
            string employeeIdentification = string.Concat(firstName, lastName);

            // string method
            string empId = firstName.ToLower() + "-" + lastName.Trim().ToLower();

            int length = empId.Length;

            if(fullName.Contains("beth") || fullName.Contains("Beth"))
            {
                Console.WriteLine("It is Bethany");
            }

            string subString = fullName.Substring(1, 3);

            Console.WriteLine("Characters 2 to 4 of full name are " + subString);

            string userNameWithInterpolation = $"{firstName}-{lastName}";
        }
        public static void UsingString()
        {
            string firstName = "Bethany";
            string lastName = "Smith";
            string s;
            s = firstName;
            var userName = "BethanyS";
            userName = userName.ToLower();

            userName = ""; // identical to string.Empty();
        }
        // using optional parameter
        public static void UsingOptionalParameter()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;

            int yearlyWageForEmployee1 = CalculateYearlyWageWithOptionals(monthlyWage1, months1);

            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}");
        }


        // Using named argument
        public static void UsingNamedArgument()
        {
            int amount = 1234;
            int month = 12;
            int bonus = 1000;

            int yearlyWageForEmployee = CalculateYearlyWageWithNamedArgument(bonus:bonus, monthlyWage:amount, numberOfMonthsWorked:month);

            Console.WriteLine($"Yearly wage for employee: {yearlyWageForEmployee}");
        }

        //Using Expression Bodied

        public static void UsingExpressionBodiedSyntax()
        {
            int amount = 1235;
            int month = 12;
            int bonus = 1000;

            int yearlyWageOfEmployee = CalculateYearlyWageWithExpressionBodied(amount, month, bonus);
        }

        // using optional parameter
        public static int CalculateYearlyWageWithOptionals(int monthlyWage, int numberOfMonthsWorked, int bonus = 5)
        {
            Console.WriteLine($"The Yearly wage: {monthlyWage + numberOfMonthsWorked + bonus}");

            return monthlyWage + numberOfMonthsWorked + bonus;
        }

        // Using named argument
        public static int CalculateYearlyWageWithNamedArgument(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            Console.WriteLine($"The Yearly wage: {monthlyWage + numberOfMonthsWorked + bonus}");

            return monthlyWage + numberOfMonthsWorked + bonus;
        }

        //Using Expression Bodied
        public static int CalculateYearlyWageWithExpressionBodied(int monthlyWage, int numberOfMonthsWorked, int bonus) => monthlyWage * numberOfMonthsWorked + bonus;

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
