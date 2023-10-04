using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.ExtensionMethods
{
    public static class EMExample
    {
        public static void ShowEMExample()
        {
            string str = "the quick brown fox jumps over the lazy dog";
            Console.WriteLine(str.SpaceCount());
            int[] nums = { 12, 34, 54, 12, 23, 77, 22, 98, 123, 56, 32, 97 };
            Console.WriteLine(nums.CountGreater(50));
        }

        public static int SpaceCount(this string input)
        {
            int count = 0;
            for(int i = 0; i < input.Length; ++i)
            {
                if (input[i] == ' ') 
                {
                    ++count;
                }
            }
            return count;
        }

        public static int CountGreater(this int[] input, int value)
        {
            int count = 0;
            for(int i = 0; i < input.Length; ++i)
            {
                if (input[i] > value)
                {
                    ++count;
                }
            }
            return count;
        }
    }
}
