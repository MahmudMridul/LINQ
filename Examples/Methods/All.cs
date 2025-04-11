using LINQ.Utils;


namespace LINQ.Examples.Methods
{
    public class All
    {
        public static void Run()
        {
            int[] nums = { 1, 2, 3, 6, 5, 3, 8, 10 };
            //checks if all the items in the IEnumerable meets the condition
            bool allArePositive = nums.All(num => num > 0);
            Printer.Print<bool>(allArePositive, nameof(allArePositive));

            string[] names = { "Alice", "Alex", "Baily", "Bob", "Barley" };
            bool allStartsWithB = names.All(name => name.StartsWith('B'));
            Printer.Print<bool>(allStartsWithB, nameof(allStartsWithB));
        }
    }
}
