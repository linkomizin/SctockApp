using System.Runtime.CompilerServices;

namespace ConsoleApp
{
    internal class Program
    {
        public static DateOnly? date;
        public class Person
        {
            public int Id { get; set; } = 1;
            public string Name { get; set; } = "Name";
        }
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            var p1 = new Person { Id = 1, Name = "Anm" };
            var p2 = new Person { Id = 2, Name = "sadasd" };
            var p3 = new Person { Id = 3, Name = "asds" };
            var p4 = new Person();
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);

            Console.WriteLine(list.Count);
            list.Remove(p1);

            Console.WriteLine(list.Count);

            list.Remove(p3);
            Console.WriteLine(list.Count);

          


        }


    }
}