namespace Shared
{
    public class Repository
    {
        static void Main(string[] args)
        {

        }
        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>()
            {
                new Employee{
                Id = 1,
                FirstName="Mohammed",
                LastName = "Hamada",
                HireDate = new DateTime(2024,10,21),
                Gender = "Male",
                Department = "CS",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 10000m
                },                new Employee{
                Id = 1,
                FirstName="momo",
                LastName = "Hamada",
                HireDate = new DateTime(2024,10,21),
                Gender = "Male",
                Department = "CS",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 10000m
                },
                new Employee{
                Id = 2,
                FirstName="Samir",
                LastName = "Hamada",
                HireDate = new DateTime(2024,10,22),
                Gender = "Male",
                Department = "Chem",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 12000m
                },
                new Employee{
                Id = 3,
                FirstName="Ahmed",
                LastName = "Mahmmoud",
                HireDate = new DateTime(2024,5,21),
                Gender = "Male",
                Department = "Math",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 16500m
                },
                new Employee{
                Id = 4,
                FirstName="Ibrahim",
                LastName = "Morad",
                HireDate = new DateTime(2023,10,21),
                Gender = "Male",
                Department = "CS",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 10600m
                },
                new Employee{
                Id = 5,
                FirstName="Esraa",
                LastName = "Salah",
                HireDate = new DateTime(2024,6,21),
                Gender = "Female",
                Department = "Phy",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 14000m
                },
                new Employee{
                Id = 6,
                FirstName="Sajid",
                LastName = "Mohammed",
                HireDate = new DateTime(2024,01,06),
                Gender = "Male",
                Department = "Medicin",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 20000m
                },
                new Employee{
                Id = 7,
                FirstName="Eslam",
                LastName = "Gomaa",
                HireDate = new DateTime(2024,01,06),
                Gender = "Male",
                Department = "Radiation",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 12000m
                },
                new Employee{
                Id = 8,
                FirstName="Eslam",
                LastName = "Ashraf",
                HireDate = new DateTime(2024,01,06),
                Gender = "Male",
                Department = "Radiation",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 12000m
                },
            };
        }
    }
}
