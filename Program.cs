using LINQ.ExtensionMethods;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "the quick brown fox jumps over the lazy dog";
            Console.WriteLine(str.SpaceCount());
            int[] nums = { 12, 34, 54, 12, 23, 77, 22, 98, 123, 56, 32, 97 };
            Console.WriteLine(nums.CountGreater(50));

        }
    }
}