using LINQ.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Examples.Methods
{
    internal class Any
    {
        public static void Run()
        {
            Console.WriteLine("***** ANY EXAMPLES *****");
            int[] nums = { 1, 2, 3, 4, 5, 4, 3, 7 };
            //checks if any item in the IEnumerable meets the condition
            bool anyGreaterThanFive = nums.Any(num => num > 5);
            Printer.Print<bool>(anyGreaterThanFive, nameof(anyGreaterThanFive));

            string[] names = { "Alice", "Bob", "Duke" };
            //checks if IEnumerable has any element
            bool namesHasElement = names.Any();
            Printer.Print<bool>(namesHasElement, nameof(namesHasElement));
        }
    }
}
