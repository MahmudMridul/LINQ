using LINQ.Utils;

namespace LINQ.Examples.Methods
{
    internal class Select : ILinqFunctions
    {
        public void Run()
        {
            int[] nums = { 2, 1, 5, 3, 10 };
            //Performs specified operation on each element
            var squaredNums = nums.Select(n => n * n);
            Printer.Print<int>(squaredNums, nameof(squaredNums));

            var students = Data.students;
            //Creating anonymous type, mofifying object, creating DTOs
            var onlyNameAndID = students.Select(person => new { ID = person.NID, Name = person.Name });
            Printer.Print(onlyNameAndID, nameof(onlyNameAndID));
        }
    }
}
