
using LINQ.Utils;

namespace LINQ.Examples.Methods
{
    public class Append
    {
        public static void Run()
        {
            int[] nums = { 1, 2, 3, 6, 5, 3, 8, 10 };
            var result = nums.Append(100);
            Printer.Print(result, nameof(result));
        }
    }
}
