using LINQ.Utils;

namespace LINQ.Examples.Methods
{
    public class Average
    {
        public static void Run()
        {
            int[] nums = { 3, 1, 5, 7, 10, 12, 20, 44, 67, 21, 100, 83 };
            //Finds average of the enumerable
            var average = nums.Average();
            Printer.Print<double>(average, nameof(average));

            var students = new List<Item>
            {
                new Item { Name = "Alice", Marks = 85.5m },
                new Item { Name = "Bob", Marks = 72.3m },
                new Item { Name = "Charlie", Marks = 90.1m },
                new Item { Name = "Diana", Marks = 66.4m },
                new Item { Name = "Ethan", Marks = 78.9m },
                new Item { Name = "Fiona", Marks = 82.2m },
                new Item { Name = "George", Marks = 59.8m },
                new Item { Name = "Hannah", Marks = 94.7m }
            };

            var averageMark = students.Average(st => st.Marks);
            Printer.Print(averageMark, nameof(averageMark));
        }
    }

    public class Item
    {
        public string Name { get; set; } = string.Empty;
        public decimal Marks {  get; set; }
    }
}
