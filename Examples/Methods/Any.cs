﻿using LINQ.Utils;

namespace LINQ.Examples.Methods
{
    public class Any
    {
        public static void Run()
        {
            int[] nums = { 1, 2, 3, 4, 5, 4, 3, 7 };
            //checks if any item in the IEnumerable meets the condition
            bool anyGreaterThanFive = nums.Any(num => num > 5);
            Printer.Print<bool>(anyGreaterThanFive, nameof(anyGreaterThanFive));

            string[] names = { "Alice", "Bob", "Duke" };
            //checks if IEnumerable has any element
            bool namesHasElement = names.Any();
            Printer.Print<bool>(namesHasElement, nameof(namesHasElement));

            //checks if nums has any elements
            bool anyNums = nums.Any();
            Printer.Print(anyNums, nameof(anyNums));

            int[] empty = { };
            bool anyElem = empty.Any();
            Printer.Print(anyElem, nameof(anyElem));
        }
    }
}
