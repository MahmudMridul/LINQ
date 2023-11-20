using LINQ.Utils;

namespace LINQ.Examples.Methods
{
    internal class Average
    {
        public static void Run()
        {
            int[] nums = { 3, 1, 5, 7, 10, 12, 20, 44, 67, 21, 100, 83 };
            //Finds average of the enumerable
            var average = nums.Average();
            Printer.Print<double>(average, nameof(average));

            var students = Data.students;
            var averageAge = students.Average(student => student.Age);
            Printer.Print<double>(averageAge, nameof(averageAge));
        }
    }
}
