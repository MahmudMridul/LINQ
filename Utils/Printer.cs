
using System.Reflection;


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
                Console.WriteLine(string.Join(" ", list) + "\n");
            }
            else
            {
                Console.WriteLine($"{listName} is empty");
            }
        }

        public static void Print<T>(object obj, string objName)
        {
            if(obj == null)
            {
                Console.WriteLine($"{objName} is NULL\n");
                return;
            }
            Type objType = obj.GetType();
            PropertyInfo[] properties = objType.GetProperties();
            Console.WriteLine($"{objName}: ");
            foreach( PropertyInfo property in properties)
            {
                var value = property.GetValue(obj);
                Console.WriteLine($"{property.Name}: {value}");
            }
            Console.WriteLine();
        }

        public static void Print<T>(IEnumerable<object> list, string listName)
        {
            Console.WriteLine($"{listName}:");
            if (list.Any())
            {
                foreach( object obj in list )
                {
                    Print<object>(obj, nameof(obj));
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{listName} is empty");
            }
        }
    }
}
