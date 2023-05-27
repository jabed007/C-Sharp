namespace _1_HelloFromCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Please enter your name: ");

            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}