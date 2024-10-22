using Shared;

namespace LinQTut03.Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunExample01();
            RunExample02();
        }

        private static void RunExample01()
        {
            string[] colorsName = { "Red", "Green", "blue" };
            string[] colorsHex = { "FF0000", "00FF00", "0000FF" };
            var color = colorsName.Zip(colorsHex, (name, hex) => $"{name} ({hex})");
            foreach (var c in color)
                Console.WriteLine(c);
        }
        private static void RunExample02()
        {
            var employees = Repository.LoadEmployees().ToArray();
            var result = from emp in employees
                         where emp.LastName.Equals("hamada", StringComparison
                         .OrdinalIgnoreCase)
                         select emp;
            result.Print("querys");
        }
    }
}