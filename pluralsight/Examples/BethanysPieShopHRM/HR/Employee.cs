using BethanysPieShopHRM.Logic;
using Newtonsoft.Json;
using System.Text;

namespace BethanysPieShopHRM.HR
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private string email;

        private DateTime birthDay;

        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyRate;

        //private EmployeeType employeeType;



        private const int minimulHoursWorkedUnit = 1;

        public static double taxRate = 0.15;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public DateTime BirthDay
        {
            get
            {
                return birthDay;
            }
            set
            {
                birthDay = value;
            }
        }

        public int NumberOfHoursWorked
        {
            get
            {
                return numberOfHoursWorked;
            }

            protected set
            {
                numberOfHoursWorked = value;
            }
        }

        public double Wage
        {
            get
            {
                return wage;
            }
            private set
            {
                wage = value;
            }
        }

        public double? HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                if (hourlyRate < 0) // this should always be higher than 0
                {
                    hourlyRate = 0;
                }
                else
                {
                    hourlyRate = value;
                }
            }
        }

        /// <summary>
        /// public EmployeeType EmployeeType { get { return employeeType; } set { employeeType = value; } }
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="em"></param>
        /// <param name="bd"></param>

        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0/*, EmployeeType.StoreManager*/)
        {

        }

        public Employee(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyRate ?? 10;
            //EmployeeType = employeeType;
        }

        public void PerformWork()
        {
            PerformWork(minimulHoursWorkedUnit);
        }

        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"The {FirstName} {LastName} has worked for {numberOfHours} hour(s)!");
        }

        public int CalculateBonus(int bonus)
        {
            if (NumberOfHoursWorked > 10)
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
            if (NumberOfHoursWorked > 10)
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

        public static void UsingCustomType()
        {
            List<string> list = new List<string>();

            StringBuilder sb = new StringBuilder();
        }

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

        public double CalculateWage()
        {
            WageCalculations wageCalculations = new WageCalculations();

            double calculatedValue = wageCalculations.ComplexWageCalculation(wage, taxRate, 3, 42);

            return calculatedValue;
        }

        public double ReceiveWage(bool resetHours = true)
        {
            //wage = numberOfHoursWorked * hourlyRate;

            //Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work");

            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value * 1.25;
            /*
            if (EmployeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"An extra was added to the wage since {firstName} is a manager");
                wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value * 1.25;
            }
            else
            {
                wageBeforeTax = numberOfHoursWorked * HourlyRate.Value;
            }*/
            double taxAmpount = wageBeforeTax * taxRate;

            Console.WriteLine("Tax amount: " + taxAmpount);

            Wage = wageBeforeTax - taxAmpount;

            Console.WriteLine($"{FirstName} {LastName} has received a wage of {Wage} for {NumberOfHoursWorked} hour(s) of work");

            if (resetHours)
            {
                NumberOfHoursWorked = 0;
            }

            return Wage;
        }



        public void EmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{FirstName}\nLast name: \t{LastName}\nEmail: \t\t{Email}\nBirth date: \t{BirthDay.ToShortDateString()}\nTax rate: \t\t{taxRate}");
        }
    }
}
