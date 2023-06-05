using System.Text;
using BethanysPieShopHRM.HR;

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
            /*
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
            */

            //Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1995, 10, 31), 25);

            //bethany.PerformWork(25);

            // Passing parameters by value
            //int minimumBonus = 100;
            //int receivedBonus = bethany.CalculateBonus(minimumBonus);
            //Console.WriteLine($"The minimum bonus is {minimumBonus} and {bethany.firstName} has received a bonus {receivedBonus}");

            // Passing parameters by reference
            //int minimumBonus = 100;
            //int bonusTax = 0; // need initialization in the context of ref keyword

            // use of ref keyword
            //int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, ref bonusTax);

            //Console.WriteLine($"The minimum bonus is {minimumBonus} and The bonus tax {bonusTax} and {bethany.firstName} has received a bonus {receivedBonus}");

            //int minimumBonus = 100;
            //int bonusTax; // do not need initialization in the context of out keyword

            ////use of out keyword
            //int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);

            //Console.WriteLine($"The minimum bonus is {minimumBonus} and The bonus tax {bonusTax} and {bethany.firstName} has received a bonus {receivedBonus}");

            // string are reference types
            //string name = "Bethany";
            //string anotherName = name;
            //name += " Smith";

            //Console.WriteLine($"Name: {name}");
            //Console.WriteLine($"Another Name: {anotherName}");

            //string upperCaseName = name.ToUpper();

            //Console.WriteLine($"Name: {name}");
            //Console.WriteLine($"Uppercase Name: {upperCaseName}");

            //string indexes = string.Empty;

            //for (int i = 0; i < 25000; i++)
            //{
            //    indexes = i.ToString();
            //}

            // uses of string builder
            //string firstName = "Bethany";
            //string lastName = "Smith";

            //StringBuilder builder = new StringBuilder();
            //builder.Append("Last Name: ");
            //builder.AppendLine(lastName);
            //builder.Append("First Name: ");
            //builder.AppendLine(firstName);
            //string result = builder.ToString();
            //Console.WriteLine(result);
            //Console.WriteLine(result.Length);

            //StringBuilder bulder2 = new StringBuilder();
            //for (int i = 0; i < 2500; i++)
            //{
            //    bulder2.Append(i);
            //    bulder2.Append(' ');
            //}
            //string list = bulder2.ToString();
            //Console.WriteLine(list);

            //Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1995, 10, 31), 25, EmployeeType.Manager);

            //bethany.ReceiveWage

            //string bethanyAsJson = bethany.ConvertToJson();
            //Console.WriteLine(bethanyAsJson);

            //WorkTask task;

            //task.description = "Bake delicious pie";
            //task.hours = 3;
            //task.PerformWorkTask();

            // Use of namespace
            BethanysPieShopHRM.Accounting.Customer customer = new BethanysPieShopHRM.Accounting.Customer();

        }
    }
}