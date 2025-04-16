
using LINQ.Utils;

namespace LINQ.Examples.Methods
{
    public class AsEnumerable
    {
        public static void Run()
        {
            CustomList<int> nums = new CustomList<int>() { 16, 4, 20, 25, 4, 15, 17 };

            IEnumerable<int> query1 = nums.Where(num => num > 15); // uses custom implementation of where
            Console.WriteLine("query1 created\n");
             
            IEnumerable<int> query2 = nums.AsEnumerable().Where(num => num >= 17); // uses LINQ implementation of where
            Console.WriteLine("query2 created\n");

            Printer.Print(query1, nameof(query1));
            Printer.Print(query2, nameof(query2));
        }
    }

    public class CustomList<T> : List<T>
    {
        public IEnumerable<T> Where(Func<T, bool> predicate)
        {
            Console.WriteLine("=== CustomList Where ===\n");
            return Enumerable.Where(this, predicate);
        }
    } 
}
