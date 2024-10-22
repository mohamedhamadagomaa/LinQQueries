namespace Shared
{
    public static class ExtensionFunctoinal01
    {
        public static IEnumerable<Employee> Filter(this IEnumerable<Employee> source, Func<Employee, bool> predicate) // Func <Employee, bool> predicate
        {

            foreach (var employee in source)
            {
                if (predicate(employee))
                {
                    yield return employee;
                }
            }
        }
        public static void Print<T>(this IEnumerable<T> source, string title)
        {
            if (source == null) return;
            Console.WriteLine();
            Console.WriteLine("ـــــــــــــــــــــــــــــــــــــــــــــــــــــــــ");
            Console.WriteLine($"|        {title.PadRight(32, ' ')}|");
            Console.WriteLine("ـــــــــــــــــــــــــــــــــــــــــــــــــــــــــ");
            Console.WriteLine();
            foreach (var item in source)
                Console.WriteLine(item);
        }
    }
}
