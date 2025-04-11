namespace LINQ.Examples.Methods
{
    public class AggregateBy
    {
        public static void Run_1()
        {
            IEnumerable<Employee> employees = new List<Employee>
            {
                new Employee { Department = "HR", Salary = 1000 },
                new Employee { Department = "HR", Salary = 1200 },
                new Employee { Department = "IT", Salary = 1300 },
                new Employee { Department = "IT", Salary = 1500 },
                new Employee { Department = "Account", Salary = 1500 },
                new Employee { Department = "Finance", Salary = 1600 },
            };

            var totalSalaryByDept = employees.AggregateBy(
                    keySelector: emp => emp.Department,
                    seed: 0,
                    func: (total, emp) => total + emp.Salary
                );

            var averageSalaryByDept = employees.AggregateBy<Employee, string, dynamic>(
                    keySelector: emp => emp.Department,
                    seedSelector: (Department) => new { Sum = 0, Count = 0 },
                    func: (acc, emp) => new { Sum = acc.Sum + emp.Salary, Count = acc.Count + 1 }
                );

            foreach (var item in totalSalaryByDept)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            foreach (var item in averageSalaryByDept)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }


        }

        public static void Run_2()
        {
            var orders = new List<Order>
            {
                new Order { ProductCategory = "Electronics", Amount = 1200 },
                new Order { ProductCategory = "Books", Amount = 50 },
                new Order { ProductCategory = "Electronics", Amount = 800 },
                new Order { ProductCategory = "Books", Amount = 30 },
                new Order { ProductCategory = "Clothing", Amount = 300 }
            };

            var salesByCategory = orders.AggregateBy(
                    keySelector: order => order.ProductCategory,
                    seed: 0,
                    func: (acc, order) => acc + order.Amount
                );

            foreach (var item in salesByCategory)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }

        public static void Run_3()
        {
            var studentScores = new List<Score>
            {
                new Score { Subject = "Math", Value = 85 },
                new Score { Subject = "Science", Value = 92 },
                new Score { Subject = "Math", Value = 78 },
                new Score { Subject = "Math", Value = 90 },
                new Score { Subject = "Science", Value = 88 },
                new Score { Subject = "History", Value = 75 },
                new Score { Subject = "Science", Value = 88 },
                new Score { Subject = "History", Value = 72 }
            };

            var subjectStats = studentScores.AggregateBy(
                keySelector: score => score.Subject,
                seedSelector: subject => new
                {
                    Count = 0,
                    Sum = 0, 
                    Min = 100, 
                    Max = 0,
                    Average = 0.0
                },
                func: (acc, score) => new
                {
                    Count = acc.Count + 1,
                    Sum = acc.Sum + score.Value,
                    Min = Math.Min(acc.Min, score.Value),
                    Max = Math.Max(acc.Max, score.Value),
                    Average = (double)acc.Sum / acc.Count
                }
            );

            foreach (var item in subjectStats)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }

        }
    }

    public class Employee
    {
        public string Department { get; set; } = String.Empty;
        public int Salary { get; set; }
    }

    public class Order
    {
        public string ProductCategory { get; set; } = String.Empty;
        public int Amount { get; set; }
    }

    public class Score
    {
        public string Subject { get; set; } = String.Empty;
        public int Value { get; set; }
    }
}
