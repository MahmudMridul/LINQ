
using LINQ.Utils;
using System.Diagnostics.CodeAnalysis;

namespace LINQ.Examples.Methods
{
    internal class Contains : ILinqFunctions
    {
        public void Run()
        {
            //Throws exception
            //int[] nums = Data.nullNums;
            int[] nums = Data.nums;
            //Checks if enumerable contains element
            bool has50 = nums.Contains(50);
            Printer.Print<bool>(has50, nameof(has50));

            Student kamal = new Student(101, "Kamal", "CSE", 20);
            Student[] students = Data.students;
            //Doesn't work like this with object as objects are compared by reference
            bool kamalIsPresent = students.Contains(kamal);
            Printer.Print<bool>(kamalIsPresent, nameof(kamalIsPresent));

            bool isKamalPresent = students.Contains(kamal, new StudentComparer());
            Printer.Print<bool>(isKamalPresent, nameof(isKamalPresent));
        }
    }

    internal class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student first, Student second)
        {
            return first.NID == second.NID;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            throw new NotImplementedException();
        }
    }
}
