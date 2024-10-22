using Shared;
namespace LinQTut01.Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();
            //var q1 = employees.Filter(x => x.Gender.Equals("female", StringComparison.OrdinalIgnoreCase) && x.FirstName.StartsWith("e", StringComparison.OrdinalIgnoreCase));
            //q1.Print("Any thing");
            var q2 = employees.Where(x => x.Gender.Equals("female", StringComparison.OrdinalIgnoreCase) && x.FirstName.StartsWith("e", StringComparison.OrdinalIgnoreCase));
            q2.Print("seconde query");
        }
    }
}