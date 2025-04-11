namespace LINQ.Examples.Methods
{
    public class AggregateBy
    {
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

        public static void Run_4()
        {
            var sentences = new List<string>
            {
                "The quick brown fox jumps over the lazy dog",
                "A Fox is a wild animal that belongs to the canid family",
                "Dogs make great pets and companions",
                "The DOG barked at the passing FOX"
            };

            var words = sentences.SelectMany(s => s.Split(' ')).Where(w => !string.IsNullOrWhiteSpace(w));

            var caseInsensitiveComparer = EqualityComparer<string>.Create(
                // Equality function (case-insensitive comparison)
                (s1, s2) => string.Equals(s1, s2, StringComparison.OrdinalIgnoreCase),
                // GetHashCode function (case-insensitive hash)
                s => s?.ToLower().GetHashCode() ?? 0
            );

            var wordCounts = words.AggregateBy(
                keySelector: word => word,
                seed: 0,
                func: (acc, word) => acc + 1,
                keyComparer: caseInsensitiveComparer
            );

            foreach(var item in wordCounts)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }
        }
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
