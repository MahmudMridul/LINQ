
using System.Reflection.Metadata.Ecma335;

namespace LINQ.Examples.Methods
{
    public class CountBy
    {
        public static void Run()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "iPhone 15", Category = "Electronics", Price = 999.99m, StockQuantity = 50 },
                new Product { Id = 2, Name = "Samsung TV", Category = "Electronics", Price = 799.50m, StockQuantity = 30 },
                new Product { Id = 3, Name = "AirPods Pro", Category = "Electronics", Price = 249.99m, StockQuantity = 75 },
                new Product { Id = 4, Name = "PlayStation 5", Category = "Electronics", Price = 499.99m, StockQuantity = 20 },
                new Product { Id = 5, Name = "Cotton T-Shirt", Category = "Clothing", Price = 19.99m, StockQuantity = 100 },
                new Product { Id = 7, Name = "Winter Jacket", Category = "Clothing", Price = 129.99m, StockQuantity = 25 },
                new Product { Id = 8, Name = "Running Shoes", Category = "Clothing", Price = 89.99m, StockQuantity = 40 },
                new Product { Id = 9, Name = "Chocolate Bar", Category = "Food", Price = 2.99m, StockQuantity = 200 },
                new Product { Id = 10, Name = "Organic Apples", Category = "Food", Price = 4.49m, StockQuantity = 150 },
                new Product { Id = 11, Name = "Bottled Water", Category = "Food", Price = 1.29m, StockQuantity = 300 },
                new Product { Id = 12, Name = "Granola Box", Category = "Food", Price = 5.99m, StockQuantity = 80 },
                new Product { Id = 13, Name = "C# Programming", Category = "Books", Price = 39.99m, StockQuantity = 35 },
                new Product { Id = 14, Name = "Sci-Fi Novel", Category = "Books", Price = 14.99m, StockQuantity = 55 },
                new Product { Id = 15, Name = "Cookbook", Category = "Books", Price = 24.99m, StockQuantity = 40 },
                new Product { Id = 16, Name = "History Book", Category = "Books", Price = 19.99m, StockQuantity = 20 },
                new Product { Id = 19, Name = "Coffee Table", Category = "Home", Price = 149.99m, StockQuantity = 15 },
                new Product { Id = 20, Name = "Wall Clock", Category = "Home", Price = 34.99m, StockQuantity = 30 }
            };

            IEnumerable<KeyValuePair<string, int>> countByCategory = products.CountBy(keySelector: product => product.Category);
            foreach (KeyValuePair<string, int> item in countByCategory)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            EqualityComparer<string> comparer = EqualityComparer<string>.Create(
                (string first, string second) => string.Equals(first, second, StringComparison.OrdinalIgnoreCase),
                (n) => n.GetHashCode()
            );

            IEnumerable<KeyValuePair<string, int>> countByCategory_2 = products.CountBy(keySelector: product => product.Category, keyComparer: comparer);
            foreach (KeyValuePair<string, int> item in countByCategory_2)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
