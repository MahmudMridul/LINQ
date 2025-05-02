using LINQ.Utils;

namespace LINQ.Examples.Methods
{
    public class Concat
    {
        public static void Run()
        {
            List<int> nums = new List<int> { 1, 2, 3, 4 };
            List<int> numb = new List<int> { 1, 2, 3, 4 };
            List<string> strings = new List<string> { "a", "b", "c" };

            // both enumerables have to of same type

            IEnumerable<int> concatenatedNums = nums.Concat(numb);
            Printer.Print(concatenatedNums);

        }
    }
}
