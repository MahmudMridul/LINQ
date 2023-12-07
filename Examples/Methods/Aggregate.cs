

using LINQ.Utils;

namespace LINQ.Examples.Methods
{
    public class Aggregate : ILinqFunctions
    {
        public void Run()
        {
            int[] nums = Data.nums;
            //Get sum of nums
            int sum = nums.Aggregate((sum, next) => sum + next);
            Printer.Print(sum, nameof(sum));

            string[] names = Data.names;
            //Get longest word from names
            string longestName = names.Aggregate((longest, next) => longest.Length >= next.Length ? longest : next);
            Printer.Print(longestName, nameof(longestName));

            //Get an enumerable of length of names
            IEnumerable<int> lengthOfNames = names.Aggregate(
                Enumerable.Empty<int>(), 
                (nameLengths, next) => nameLengths.Append(next.Length)
            );
            Printer.Print(lengthOfNames, nameof(lengthOfNames));
        }
    }
}
