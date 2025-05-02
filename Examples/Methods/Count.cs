
using LINQ.Utils;

namespace LINQ.Examples.Methods
{
    public class Count
    {
        public static void Run()
        {
            List<Product> products = new List<Product>
            {
                // Electronics (4 items)
                new Product { Id = 1, Name = "iPhone 15", Category = "Electronics", Price = 999.99m, StockQuantity = 50 },
                new Product { Id = 2, Name = "Samsung TV", Category = "Electronics", Price = 799.50m, StockQuantity = 30 },
                new Product { Id = 3, Name = "AirPods Pro", Category = "Electronics", Price = 249.99m, StockQuantity = 75 },
                new Product { Id = 4, Name = "PlayStation 5", Category = "Electronics", Price = 499.99m, StockQuantity = 20 },

                // Clothing (4 items)
                new Product { Id = 5, Name = "Cotton T-Shirt", Category = "Clothing", Price = 19.99m, StockQuantity = 100 },
                new Product { Id = 6, Name = "Denim Jeans", Category = "Clothing", Price = 59.99m, StockQuantity = 60 },
                new Product { Id = 7, Name = "Winter Jacket", Category = "Clothing", Price = 129.99m, StockQuantity = 25 },
                new Product { Id = 8, Name = "Running Shoes", Category = "Clothing", Price = 89.99m, StockQuantity = 40 },

                // Food (4 items)
                new Product { Id = 9, Name = "Chocolate Bar", Category = "Food", Price = 2.99m, StockQuantity = 200 },
                new Product { Id = 10, Name = "Organic Apples", Category = "Food", Price = 4.49m, StockQuantity = 150 },
                new Product { Id = 11, Name = "Bottled Water", Category = "Food", Price = 1.29m, StockQuantity = 300 },
                new Product { Id = 12, Name = "Granola Box", Category = "Food", Price = 5.99m, StockQuantity = 80 },

                // Books (4 items)
                new Product { Id = 13, Name = "C# Programming", Category = "Books", Price = 39.99m, StockQuantity = 35 },
                new Product { Id = 14, Name = "Sci-Fi Novel", Category = "Books", Price = 14.99m, StockQuantity = 55 },
                new Product { Id = 15, Name = "Cookbook", Category = "Books", Price = 24.99m, StockQuantity = 40 },
                new Product { Id = 16, Name = "History Book", Category = "Books", Price = 19.99m, StockQuantity = 20 },

                // Home (4 items)
                new Product { Id = 17, Name = "Desk Lamp", Category = "Home", Price = 29.99m, StockQuantity = 45 },
                new Product { Id = 18, Name = "Throw Pillow", Category = "Home", Price = 12.99m, StockQuantity = 70 },
                new Product { Id = 19, Name = "Coffee Table", Category = "Home", Price = 149.99m, StockQuantity = 15 },
                new Product { Id = 20, Name = "Wall Clock", Category = "Home", Price = 34.99m, StockQuantity = 30 }
            };

            Func<Product, bool> food = (product) => product.Category == "Food";
            Func<Product, bool> lessStock = (product) => product.StockQuantity < 30;

            int numberofProducts = products.Count();
            Printer.Print(numberofProducts, nameof(numberofProducts));

            int foodItems = products.Count(food);
            Printer.Print(foodItems, nameof(foodItems));

            int lessStockItems = products.Count(lessStock);
            Printer.Print(lessStockItems, nameof(lessStockItems));
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
