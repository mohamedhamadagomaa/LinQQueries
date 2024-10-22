using LINQTut05.Shared;

namespace LINQTut05.ThenBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();
            var sortedEmps = emps.OrderBy(e => e.Name).ThenBy(e => e.Salary);
            sortedEmps.Print("Sorted by name then by salary");


        }
    }
}
