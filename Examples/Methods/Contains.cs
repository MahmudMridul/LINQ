
using LINQ.Utils;
using System.Diagnostics.CodeAnalysis;

namespace LINQ.Examples.Methods
{
    internal class Contains
    {
        public static void Run()
        {
            //Throws exception
            //int[] nums = Data.nullNums;
            int[] nums = Data.nums;
            //Checks if enumerable contains element
            bool has50 = nums.Contains(50);
            Printer.Print<bool>(has50, nameof(has50));

            Person kamal = new Person(101, "Kamal", "Student", 20, "Single");
            Person[] students = Data.students;
            //Doesn't work like this with object as objects are compared by reference
            bool kamalIsPresent = students.Contains(kamal);
            Printer.Print<bool>(kamalIsPresent, nameof(kamalIsPresent));

            bool isKamalPresent = students.Contains(kamal, new StudentComparer());
            Printer.Print<bool>(isKamalPresent, nameof(isKamalPresent));
        }
    }

    internal class StudentComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person first, Person second)
        {
            return first.NID == second.NID;
        }

        public int GetHashCode([DisallowNull] Person obj)
        {
            throw new NotImplementedException();
        }
    }
}
