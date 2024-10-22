using LINQTut05.Shared;

namespace LINQTut05.OrderBy.Comparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> emps = Repository.LoadEmployees();
            IOrderedEnumerable<Employee> sortedEmpls =
                emps.OrderBy(e => e, new EmployeeComparer());
            sortedEmpls.Print("sorted emps");
        }
    }
}
