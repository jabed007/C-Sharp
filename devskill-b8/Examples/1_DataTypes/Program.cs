namespace _1_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s1 = "Jalal";
            string s2 = "Uddin";

            Int32 i1 = 4;
            int i2 = 5;

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            // Array
            int size = 20;
            int[] ages = new int[size];
            ages[0] = 1;
            ages[1] = 2;

            int[] scores = new int[] { 3, 4, 5};

            // set value in array
            int a = ages[0];
            scores[1] = 90;

            // Two Dimensional Array
            int[,] positions = new int[10, 10];
            positions[0, 0] = 10;
            positions[0, 1] = 20;

            int t = positions[0, 1];

            string[,] something = new string[10, 10];

            int[,] positions2 = new int[,] { { 4, 2}, { 5, 3} };

            // Jagged Array
            int[][] scores2 = new int[10][];
            scores2[0] = new int[5];
            scores2[1] = new int[3];
            scores2[2] = new int[7];

            scores2[0][0] = 1;
            scores2[0][1] = 2;
            scores2[0][2] = 3;
            scores2[0][3] = 4;
            scores2[0][4] = 6;

            scores2[1][0] = 7;
            scores2[1][1] = 8;
            scores2[1][2] = 9;

            scores2[2][0] = 10;
            scores2[2][1] = 11;
            scores2[2][2] = 12;

            Console.WriteLine(scores2[2][2]);

            // Find sie of jagged array/array
            Console.WriteLine(scores2.Length);
            Console.WriteLine(scores2[0].Length);

            // Find rank of array
            Console.WriteLine(something.Rank);
            Console.WriteLine(scores2.Rank);

            // use of var
            var x = 5;
            var y = 5.5;
            var z = true;
            var w = "hello";

            var text = GetSomething();
            Console.WriteLine(text);

            var s4 = 0;
            var line = Console.ReadLine();
            s4 = int.Parse(line);
            Console.WriteLine(s4 + 10);

            int ninetyNine = Convert.ToInt32("99");
            Console.WriteLine(ninetyNine);

        }

        public static string GetSomething()
        {
            return "Hello";
        }
    }
}