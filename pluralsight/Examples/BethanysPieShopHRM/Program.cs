namespace BethanysPieShopHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bethany's Pie Shop HRM");

            Console.WriteLine("Please enter your name: ");

            //string name = Console.ReadLine();

            //string name2 = Console.ReadLine();

            //string name_2 = Console.ReadLine();

            //string Name_2 = Console.ReadLine();

            int monthlyWage = 1234;

            int months = 12, bonus = 1000;

            bool isActive = true;

            double rating = 99.25;

            //byte numberOfEmployees = 300;

            int hoursWorked = 125;


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

        }
    }
}