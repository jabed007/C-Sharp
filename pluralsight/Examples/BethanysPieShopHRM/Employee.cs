﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public DateTime birthDay;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        

        const int minimulHoursWorkedUnit = 1;

        public Employee(string first, string last, string em, DateTime bd):this(first, last, em, bd, 0)
        {

        }

        public Employee(string first, string last, string em, DateTime bd, double rate)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthDay = bd;
            hourlyRate = rate;
        }

        public void PerformWork()
        {
            PerformWork(minimulHoursWorkedUnit);
        }

        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"The {firstName} {lastName} has worked for {numberOfHours} hour(s)!");
        }

        public int CalculateBonus(int bonus)
        {
            if (numberOfHoursWorked > 10)
            {
                bonus *= 2;
            }
            Console.WriteLine($"The Employee got a bonus {bonus}");
            return bonus;
        }

        // use of ref keyword
        //public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        //{
        //    if (numberOfHoursWorked > 10)
        //    {
        //        bonus *= 2;
        //        bonusTax = bonus / 10;
        //        bonus -= bonusTax;
        //    }
        //    Console.WriteLine($"The Employee got a bonus {bonus}");

        //    return bonus;
        //}

        // use of out keyword
        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (numberOfHoursWorked > 10)
            {
                bonus *= 2;
            }

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }
            Console.WriteLine($"The Employee got a bonus {bonus}");

            return bonus;
        }

        public double ReceiveWage(bool resetHours = true)
        {
            wage = numberOfHoursWorked * hourlyRate;

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work");

            if (resetHours)
            {
                numberOfHoursWorked = 0;
            }

            return wage;
        }

        public void EmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\nBirth date: \t{birthDay.ToShortDateString()}");
        }
    }
}