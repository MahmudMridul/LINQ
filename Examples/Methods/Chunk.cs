
using LINQ.Utils;

namespace LINQ.Examples.Methods
{
    public class Chunk
    {
        public static void Run()
        {
            int[] nums = { 11, 10, 4, 22, 14, 99, 55, 23 };
            IEnumerable<int[]> chunks = nums.Chunk(3);

            foreach (var chunk in chunks)
            {
                Printer.Print(chunk);
            }
        }
    }
}
