namespace BethanysPieShopHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Welcome to Bethany's Pie Shop HRM");

            Console.WriteLine("Please enter your name: ");

            string name = Console.ReadLine();

            string name2 = Console.ReadLine();

            string name_2 = Console.ReadLine();

            string Name_2 = Console.ReadLine();

            var monthlyWage = 1234;

            //int months = 12, bonus = 1000;

            var isActive = true;

            var rating = 99.25;

            var numberOfEmployees = 300;

            var hoursWorked = 125;


            hoursWorked = 148;

            //monthlyWage = true;
            const double interestRate = 0.07;

            //interestRate = 0.08;

            string firstName = "Bethany";
            string lastName = "Smith";

            string emptyString = "";

            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            double ratePerHour = 12.34;
            int numberOfHoursWorked = 165;

            double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;
            Console.WriteLine(currentMonthWage);

            ratePerHour += 3;
            Console.WriteLine(ratePerHour);

            if (currentMonthWage > 2000)
                Console.WriteLine("Top paid employee!");

            int numberOfEmployees = 15;
            numberOfEmployees--;
            Console.WriteLine(numberOfEmployees);

            bool a = true;
            int b = 10;

            Console.WriteLine(a);

            int intMaxValue = int.MaxValue;
            int intMinValue = int.MinValue;

            char userSelction = 'a';
            char upperVersion = char.ToUpper(userSelction);

            bool isDigit = char.IsDigit(userSelction);
            bool isLetter = char.IsLetter(userSelction);

            Console.ReadLine();

            DateTime hireDate = new DateTime(2023, 3, 23, 14, 30, 0);
            Console.WriteLine(hireDate);

            DateTime exitDate = new DateTime(2025, 8, 12);
            Console.WriteLine(exitDate);

            DateTime invalidDate = new DateTime(2022, 13, 32); // unrepresentable date time
            Console.WriteLine(invalidDate);

            DateTime startDate = hireDate.AddDays(15);
            Console.WriteLine(startDate);

            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);

            bool areWeInDst = currentDate.IsDaylightSavingTime();


            DateTime startHour = DateTime.Now;
            TimeSpan workHour = new TimeSpan(8, 35, 00);
            DateTime endHour = startHour.Add(workHour);

            Console.WriteLine(startHour);
            Console.WriteLine(workHour);
            Console.WriteLine(endHour);

            Console.WriteLine("---------------------------");

            Console.WriteLine(startHour.ToLongDateString());
            Console.WriteLine(startHour.ToLongTimeString());

            Console.WriteLine("---------------------------");

            Console.WriteLine(endHour.ToShortDateString());
            Console.WriteLine(endHour.ToShortTimeString());

            int numberOfHoursWorked = 165;
            long veryLongMonth = numberOfHoursWorked; // works fine
            double d = 12345678.0;

            int x = (int)d;

            int intVeryLongMonth = (int)veryLongMonth;

            DateTime today = DateTime.Now;
            bool endOfMonthPaymentStarted = false;

            if (today.Date.Day == 20)
            {
                Console.WriteLine("Please start end-of-month employee payments");
            }
            else if (today.Date.Day >= 25 && !endOfMonthPaymentStarted)
            {
                Console.WriteLine("Payment will be late");
            }

            Console.WriteLine("Choose the action you want to do: ");
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. Update employee");
            Console.WriteLine("3. Delete employee");
            Console.WriteLine("99. Exit application");

            string selectedAction = Console.ReadLine();

            while (selectedAction != "99")
            {
                switch (selectedAction)
                {
                    case "1":
                        Console.WriteLine("Adding new employee ...");
                        break;
                    case "2":
                        Console.WriteLine("Updating employee ...");
                        break;
                    case "3":
                        Console.WriteLine("Deleting employee ...");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

                Console.WriteLine("Choose the action you want to do: ");
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. Update employee");
                Console.WriteLine("3. Delete employee");
                Console.WriteLine("99. Exit application");

                selectedAction = Console.ReadLine();
            }

            string selectedAction;

            do
            {
                Console.WriteLine("Choose the action you want to do: ");
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. Update employee");
                Console.WriteLine("3. Delete employee");
                Console.WriteLine("99. Exit application");
                selectedAction = Console.ReadLine();

                switch (selectedAction)
                {
                    case "1":
                        Console.WriteLine("Adding new employee ...");
                        break;
                    case "2":
                        Console.WriteLine("Updating employee ...");
                        break;
                    case "3":
                        Console.WriteLine("Deleting employee ...");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            while (selectedAction != "99");

            int amount = 1234;
            int months = 12;
            int bonus = 1000;

            Utilities.CalculateYearlyWage(amount, months, bonus);

            int yearlyWage = Utilities.CalculateYearlyWage(amount, months, bonus);

            Console.WriteLine($"Yearly wage: {yearlyWage}");

            double amountDouble = 1500.0;
            double monthsDouble = 12;
            double bonusDouble = 1000;

            double yearlyWageWithBonusDouble = Utilities.CalculateYearlyWage(amountDouble, monthsDouble, bonusDouble);

            Utilities.UsingOptionalParameter();

            Utilities.UsingNamedArgument();

            Utilities.ManifulatingString();

            Utilities.UsingEscapeCharacter();

            Utilities.UsingStringEuality();

            Utilities.ParsingString();
            */

            /////////////////////////////////////////////////
            ////*****Working with classes and objects***////
            ///////////////////////////////////////////////
            /*
            Console.WriteLine("Creating an employee");
            Console.WriteLine("--------------------\n");

            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1995, 10, 31), 25);

            bethany.EmployeeDetails();
            bethany.PerformWork();
            bethany.PerformWork(5);
            bethany.PerformWork();
            bethany.PerformWork();

            double receivedWageBethany = bethany.ReceiveWage(true);
            Console.WriteLine($"Wage paid (message from program): {receivedWageBethany}");

            Console.WriteLine("\n\n");

            Console.WriteLine("Creating an employee");
            Console.WriteLine("--------------------\n");

            Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);

            george.EmployeeDetails();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork(3);
            george.PerformWork();
            george.PerformWork(8);

            var receivedWageGeorge = george.ReceiveWage(true);
            Console.WriteLine($"Wage paid (message from program): {receivedWageGeorge}");

            Console.WriteLine("\n\n");

            Console.WriteLine("Creating an employee");
            Console.WriteLine("--------------------\n");

            bethany.firstName = "John";
            bethany.hourlyRate = 10;

            bethany.EmployeeDetails();
            bethany.PerformWork();
            bethany.PerformWork(12);
            bethany.PerformWork();
            bethany.PerformWork();

            double receivedWageJohn = bethany.ReceiveWage(true);
            Console.WriteLine($"Wage paid (message from program): {receivedWageJohn}");
            */

            /////////////////////////////////////////////////////////////
            ////*****Working with value types and reference types***////
            ///////////////////////////////////////////////////////////

            // Value type
            int a = 42;
            int aCopy = a;

            Console.WriteLine($"Value of a = {a} and value of copy of a = {aCopy}");

            aCopy = 100;

            Console.WriteLine($"Value of a = {a} and value of copy of a = {aCopy}");

            // Reference type
            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1995, 10, 31), 25);

            Employee testEmployee = bethany;
            testEmployee.firstName = "Gill";

            bethany.EmployeeDetails();
            testEmployee.EmployeeDetails();
        }
    }
}