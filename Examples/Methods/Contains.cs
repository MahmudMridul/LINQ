
using LINQ.Utils;

namespace LINQ.Examples.Methods
{
    public class Contains
    {
        public static void Run()
        {
            //Throws exception
            //int[] nums = Data.nullNums;
            int[] nums = { 1, 2, 3, 6, 5, 3, 8, 10 };
            //Checks if enumerable contains element
            bool has50 = nums.Contains(50);
            Printer.Print(has50, nameof(has50));

            bool has6 = nums.Contains(6);
            Printer.Print(has6, nameof(has6));

            var list = new List<ContainsObject>
            {
                new() { Id = 1, Name = "Item 1", Flag = true },
                new() { Id = 2, Name = "Item 2", Flag = false },
                new() { Id = 3, Name = "Item 3", Flag = true },
                new() { Id = 4, Name = "Item 4", Flag = false },
                new() { Id = 5, Name = "Item 5", Flag = true },
                new() { Id = 6, Name = "Item 6", Flag = false },
                new() { Id = 7, Name = "Item 7", Flag = true },
                new() { Id = 8, Name = "Item 8", Flag = false }
            };

            var idComparer = EqualityComparer<ContainsObject>.Create(
                (first, second) => first.Id == second.Id, 
                obj => obj.Id.GetHashCode()
            );

            var hasId5 = list.Contains(new ContainsObject { Id = 5, Name = "Name", Flag = false }, idComparer);
            Printer.Print(hasId5, nameof(hasId5));

            var nameComparer = EqualityComparer<ContainsObject>.Create(
                (first, second) => first.Name.Equals(second.Name),
                obj => obj.Name.GetHashCode()
            );

            var hasName = list.Contains(new ContainsObject { Id = 3, Name = "Name", Flag = false }, nameComparer);
            Printer.Print(hasName, nameof(hasName));


            
        }
    }

    public class ContainsObject
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool Flag { get; set; }
    }
}
