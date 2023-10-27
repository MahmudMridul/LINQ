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
        //public static void PrintEnumerable(IEnumerable<T> items, string itemsName)
        //{
        //    Console.WriteLine($"{itemsName.ToUpper()}:");
        //    foreach (T item in items) 
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.WriteLine("\n");
        //}

        //public static void PrintVariable(T value, string name)
        //{
        //    Console.WriteLine($"\n{name}: {value}\n");
        //}

        public static void Print<T>(T value, string name)
        {
            Console.WriteLine($"{name}: {value}\n");
        }
    }
}
