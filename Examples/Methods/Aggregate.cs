using LINQ.Utils;

namespace LINQ.Examples.Methods
{
    public class Aggregate
    {
        public static void Run()
        {
            // Aggregate is 3 overloads

            int[] nums = { 2, 1, 4, 6, 5, 7, 9, 3, 10, 8 };
            // the first overload takes 3 params
            // first param is the initial value, second is the accumulator function, third is the result selector function
            int sum = nums.Aggregate(0, (sum, next) => sum + next, result => result * 10);
            Printer.Print(sum, nameof(sum));

            // the second overload takes 2 params
            // first param is the initial value, second is the accumulator function
            int numOfEven = nums.Aggregate(0, (count, next) => next % 2 == 0 ? count + 1 : count);
            Printer.Print(numOfEven, nameof(numOfEven));

            // the third overload takes 1 param
            // the only param is the accumulator function
            int sumOfAll = nums.Aggregate((sum, next) => sum + next);
            Printer.Print(sumOfAll, nameof(sumOfAll));

            string[] names = { "cat", "apple", "banana", "cherry", "dragonfly", "encyclopedia",
                                "philosophical", "hippopotamus", "unbelievable", "conversation",
                                "imagination", "understanding", "constitution", "responsibility",
                                "supercalifragilisticexpialidocious", "internationalization" };


            int countOfOddLengthStrings = names.Aggregate(0, (count, next) => next.Length % 2 == 1 ? count + 1 : count);
            Printer.Print(countOfOddLengthStrings, nameof(countOfOddLengthStrings));


            string longestName = names.Aggregate("", (longest, next) => longest.Length >= next.Length ? longest : next, result => result.ToUpper());
            Printer.Print(longestName, nameof(longestName));


            IEnumerable<int> lengthOfNames = names.Aggregate(
                Enumerable.Empty<int>(), 
                (nameLengths, next) => nameLengths.Append(next.Length)
            );
            Printer.Print(lengthOfNames, nameof(lengthOfNames));
        }
    }
}
