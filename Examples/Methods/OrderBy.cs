
using LINQ.Utils;

namespace LINQ.Examples.Methods
{
    internal class OrderBy : ILinqFunctions
    {
        public void Run()
        {
            int[] nums = Data.nums;
            IEnumerable<int> orderedNumes = nums.OrderBy(num => num);
            Printer.Print<int>(orderedNumes, nameof(orderedNumes));
        }
    }
}
