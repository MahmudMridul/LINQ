using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Utils
{
    internal static class Printer
    {
        public static void Print<T>(T value, string name)
        {
            Console.WriteLine($"{name}: {value}\n");
        }

        public static void Print<T>(IEnumerable<T> list, string listName) 
        {
            Console.WriteLine($"{listName}:");
            if(list.Any())
            {
                Console.WriteLine(string.Join("\n", list));
            }
            else
            {
                Console.WriteLine($"{listName} is empty");
            }
        }
    }
}
