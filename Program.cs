using LINQ.ExtensionMethods;
using LINQ.DeferredExecution;
using LINQ.Examples.Methods;

namespace LINQ
{
    public class Program
    {
        private static ILinqFunctions? _runner;

        public static void Main(string[] args)
        {
            _runner = new All();
            RunExample(_runner);
        }

        public static void RunExample(ILinqFunctions example)
        {
            example.Run();
        }
    }
}