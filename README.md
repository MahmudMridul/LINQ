# LINQ Functions

## Methods

### AsEnumerable
**Here are some useful usecases of `AsEnumerable`**

#### 1. Deferring query execution from LINQ to SQL/Entity Framework
```
// Without AsEnumerable() - entire filtering happens at database level
var customersFromDb = dbContext.Customers
    .Where(c => c.Country == "USA")
    .OrderBy(c => c.Name)
    .Take(10)
    .ToList();

// With AsEnumerable() - filtering by Country happens at DB level,
// but the string comparison happens in memory after data is retrieved
var customers = dbContext.Customers
    .Where(c => c.Country == "USA")
    .AsEnumerable()
    .Where(c => c.Name.Contains("John", StringComparison.OrdinalIgnoreCase))
    .Take(10)
    .ToList();
```

#### 2. Change LINQ provider/context
```
// Force using LINQ to Objects methods rather than LINQ to SQL methods
var localProcessing = dbContext.Products
    .AsEnumerable()
    .Where(p => CustomLocalFunction(p.Price))
    .ToList();

bool CustomLocalFunction(decimal price)
{
    // Complex calculation that can't be translated to SQL
    return Math.Sqrt((double)price) > 10;
}
```
#### 3. Using custom implementation
```
public class CustomList<T> : List<T>
{
    public IEnumerable<T> Where(Func<T, bool> predicate)
    {
        Console.WriteLine("=== CustomList Where ===\n");
        return Enumerable.Where(this, predicate);
    }
} 

CustomList<int> nums = new CustomList<int>() { 16, 4, 20, 25, 4, 15, 17 };

// uses custom implementation of where
IEnumerable<int> query1 = nums.Where(num => num > 15);
             
// uses LINQ implementation of where
IEnumerable<int> query2 = nums.AsEnumerable().Where(num => num >= 17); 
```
