﻿using System.Text;
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
            //BethanysPieShopHRM.Accounting.Customer customer = new BethanysPieShopHRM.Accounting.Customer();

            //Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1995, 12, 23), 25, EmployeeType.Manager);

            //Employee john = new Employee("John", "Doe", "john@snowball.be", new DateTime(1990, 10, 10), null, EmployeeType.Research);

            //#region Bethany First call
            //bethany.PerformWork();
            //bethany.PerformWork();

            //bethany.PerformWork(5);

            //bethany.PerformWork();

            //bethany.PerformWork();

            //bethany.ReceiveWage();

            //#endregion

            //#region John First call
            //john.PerformWork();
            //john.PerformWork();

            //john.PerformWork(5);

            //john.PerformWork();

            //john.PerformWork();

            //john.ReceiveWage();

            //#endregion

            //Employee.taxRate = 0.02;

            //#region Bethany Second call
            //bethany.PerformWork();
            //bethany.PerformWork();

            //bethany.PerformWork(5);

            //bethany.PerformWork();

            //bethany.PerformWork();

            //bethany.ReceiveWage();

            //#endregion

            //#region John Second call
            //john.PerformWork();
            //john.PerformWork();

            //john.PerformWork(5);

            //john.PerformWork();

            //john.PerformWork();

            //john.ReceiveWage();

            //#endregion

            // Using null
            //Employee mysteryEmployee = null;
            //mysteryEmployee.EmployeeDetails();

            //List<Employee> employees = new List<Employee>();

            //for (int i = 0; i < 10000000; i++)
            //{
            //    Employee randomEmployee = new Employee(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), new DateTime(1991, 3, 16), null, EmployeeType.Sales);
            //    employees.Add(randomEmployee);
            //}

            //employees.Clear();
            //employees = null;

            //GC.Collect();

            //Console.ReadLine();

            //Employee bethany = new Employee("John", "Doe", "john@snowball.be", new DateTime(1990, 10, 10), null, EmployeeType.Research);
            //bethany.CalculateWage();

            // Array

            //int[] sampleArray1 = new int[5];
            //int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5 };

            ////Error array
            ////int[] sampleArray3 = new int[5] { 1, 2, 3, 4, 5, 6 }; // provide compile time error

            //Console.WriteLine("How many employee do you want to register");
            //int length = int.Parse(Console.ReadLine());

            //int[] employeeIds = new int[length];

            //for (int i = 0; i < length; i++)
            //{
            //    Console.Write("Enter the employee ID: ");
            //    int id = int.Parse(Console.ReadLine());
            //    employeeIds[i] = id;
            //}

            //Console.WriteLine("After sorting");

            //for (int i = 0; i < employeeIds.Length; i++)
            //{
            //    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
            //}

            //// Built in array method
            //// sort method
            //Array.Sort(employeeIds);

            //Console.WriteLine("After sorting");

            //for (int i = 0; i < employeeIds.Length; i++)
            //{
            //    Console.WriteLine($"Id {i + 1}: \t{employeeIds[i]}");
            //}

            //// copyTo method
            //var employeeIdsCopy = new int[length];
            //employeeIds.CopyTo(employeeIdsCopy, 0);

            //// reverse method
            //Array.Reverse(employeeIds);

            //Console.WriteLine("After reverse main array");

            //for (int i = 0; i < employeeIds.Length; i++)
            //{
            //    Console.WriteLine($"Id {i + 1}: \t{employeeIds[i]}");
            //}

            //Console.WriteLine("After reverse copy array");

            //for (int i = 0; i < employeeIdsCopy.Length; i++)
            //{
            //    Console.WriteLine($"Id {i + 1}: \t{employeeIdsCopy[i]}");
            //}
            // Working with an array of employee objects
            //Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
            //Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
            //Employee mary = new Employee("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);
            //Employee bobJunior = new Employee("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17, EmployeeType.Research);
            //Employee kevin = new Employee("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10, EmployeeType.StoreManager);
            //Employee kate = new Employee("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10, EmployeeType.StoreManager);
            //Employee kim = new Employee("Kim", "Jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22, EmployeeType.StoreManager);

            //Employee[] employees = new Employee[7];
            //employees[0] = bethany;
            //employees[1] = george;
            //employees[2] = mary;
            //employees[3] = bobJunior;
            //employees[4] = kevin;
            //employees[5] = kate;
            //employees[6] = kim;

            //foreach(Employee emp in employees)
            //{
            //    emp.EmployeeDetails();
            //    var numberOfHoursWorked = new Random().Next(25);
            //    emp.PerformWork(numberOfHoursWorked);
            //    emp.ReceiveWage();
            //}

            // working with list

            //List<int> employeeIds = new List<int>();

            //employeeIds.Add(55);
            //employeeIds.Add(57);
            //employeeIds.Add(99);
            //employeeIds.Add(35);
            //employeeIds.Add(100);


            //if (employeeIds.Contains(99))
            //{
            //    Console.WriteLine("99 is found");
            //}

            //var currentAmountOfEmployees = employeeIds.Count();

            //Console.WriteLine(currentAmountOfEmployees);

            //var employeeIdsArray = employeeIds.ToArray();

            ////Console.WriteLine(employeeIdsArray);

            //employeeIds.Clear();

            //Console.WriteLine("How many employees id's do you want to registered");

            //var length = int.Parse(Console.ReadLine());

            //for (int i = 0; i < length; i++)
            //{
            //    Console.Write($"Enter employee id {i + 1}: ");
            //    var employeeId = int.Parse(Console.ReadLine());
            //    employeeIds.Add(employeeId);
            //}

            //for (int i = 0; i < employeeIds.Count; i++)
            //{
            //    Console.WriteLine($"Employee id {i + 1}: {employeeIds[i]}");
            //}

            //Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
            //Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
            //Employee mary = new Employee("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);
            //Employee bobJunior = new Employee("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17, EmployeeType.Research);
            //Employee kevin = new Employee("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10, EmployeeType.StoreManager);
            //Employee kate = new Employee("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10, EmployeeType.StoreManager);
            //Employee kim = new Employee("Kim", "Jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22, EmployeeType.StoreManager);

            //List<Employee> employees = new List<Employee>();

            //employees.Add(george);
            //employees.Add(mary);
            //employees.Insert(0, bethany);
            //employees.Add(bobJunior);
            //employees.Add(kate);
            //employees.Add(kim);

            //foreach (Employee employee in employees)
            //{
            //    employee.EmployeeDetails();
            //}

            //Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25 /*EmployeeType.Manager*/);
            //Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30/*, EmployeeType.Research*/);

            //bethany.EmployeeDetails();
            //bethany.PerformWork(8);
            //bethany.PerformWork();
            //bethany.PerformWork(3);
            //bethany.ReceiveWage();

            //bethany.FirstName = "Bethany";

            //string fn = bethany.FirstName;

            ////Manager mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
            //Employee mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
            ////JuniorResearcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);
            //Researcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);
            //Employee jake = new Employee("Jake", "Nikols", "jake@snowball.be", new DateTime(1995, 8, 16), 25, "New Street", "123", "123456", "Pie Ville");

            //string street = jake.Address.Street;
            //Console.WriteLine(street);

            //mary.EmployeeDetails();
            //mary.PerformWork(4);
            //mary.PerformWork(5);
            //mary.PerformWork();
            //mary.PerformWork();
            //mary.ReceiveWage();
            ////mary.AttendManagementMeeting(); // error

            //bobJunior.ReasearchNewPieTastes(5);
            //bobJunior.ReasearchNewPieTastes(5);

            Employee bethany = new StoreManager("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
            Manager mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
            JuniorResearcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);
            StoreManager kevin = new StoreManager("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10);
            StoreManager kate = new StoreManager("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);

            List<Employee> employees = new List<Employee>();

            employees.Add(bethany);
            employees.Add(mary);
            employees.Add(kevin);
            employees.Add(kate);

            foreach(var employee in employees)
            {
                employee.EmployeeDetails();
                employee.GiveBonus();
            }
        }
    }
}