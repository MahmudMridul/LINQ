﻿using LINQ.Utils;


namespace LINQ.Examples.Methods
{
    internal class All : ILinqFunctions
    {
        public void Run()
        {
            int[] nums = { 1, 2, 3, 6, 5, 3, 8, 10 };
            //checks if all the items in the IEnumerable meets the condition
            bool allArePositive = nums.All(num => num > 0);
            Printer.Print<bool>(allArePositive, nameof(allArePositive));
        }
    }
}
