using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.ExtensionMethods
{
    public static class EMExample
    {
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
