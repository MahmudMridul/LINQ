
using LINQ.Utils;

namespace LINQ.Examples.Methods
{
    internal class Where : ILinqFunctions
    {
        public void Run()
        {
            int[] nums = Data.nums;
            //Returns IEnumerable of data that satisfies condition
            IEnumerable<int> greaterThan50 = nums.Where(num => num > 50);
            Printer.Print<int>(greaterThan50, nameof(greaterThan50));

            Person[] people = Data.people;
            IEnumerable<Person> doctors = people.Where(person => person.Profession == "Doctor");
            Printer.Print<object>(doctors, nameof(doctors));
            //Accessing index
            IEnumerable<Person> engineers = people.Where((person, index) => { 
                Console.WriteLine($"{person.Name} - {index}");
                return person.Profession == "Engineer";
            });
            Printer.Print<object>(engineers, nameof(engineers));
        }
    }
}
