using System.Runtime.CompilerServices;

namespace ConsoleApp
{
    internal class Program
    {
        public static DateOnly? date;

        static void Main(string[] args)
        {
            int[] arr = new[] {33, 44, 55};

            Console.WriteLine("Hello, World!");

            for (int i = 0; i < arr.Length ; i++)
            {
                for (int j = i + 1; j < arr.Length ; j++)
                {
                    //( arr[i], arr[j]);
                    Console.WriteLine($"{i} - {j}");
                }
            }
        }

        public static void MyMethod(DateOnly? date)
        {
            date = Program.date;
            Console.WriteLine(Program.date.HasValue);
        }
    }
}