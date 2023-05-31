namespace BethanysPieShopHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}