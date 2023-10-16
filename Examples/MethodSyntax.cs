using LINQ.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Examples
{
    internal class MethodSyntax
    {
        public static void AnyExample()
        {
            int[] nums = Data.GetIntArray();
            bool moreThanTen = nums.Any(num => num > 10);
            Console.WriteLine($"Numbers: {string.Join(" ", nums)}");
            Console.WriteLine($"More than 10: {moreThanTen}");

            IEnumerable<Pet> pets = Data.Pets;
            Printer<Pet>.PrintEnumerable(pets, nameof(pets));
            bool nameLength = pets.Any(pet => pet.Name.Length > 5);
            Console.WriteLine($"Name lenght more than 5: {nameLength}");
        }

        public static void AllExample()
        {
            IEnumerable<Pet> pets = Data.Pets;
            Printer<Pet>.PrintEnumerable(pets, nameof(pets));
            bool allCat = pets.All(pet => pet.PetType == PetType.Cat);
            Console.WriteLine($"All cat: {allCat}");
        }

        public static void CountExample()
        {
            IEnumerable<Pet> pets = Data.Pets;
            Printer<Pet>.PrintEnumerable(pets, nameof(pets));
            int cats = pets.Count(pet => pet.PetType == PetType.Cat);
            long heavyDogs = pets.LongCount(pet => pet.PetType == PetType.Dog && pet.Weight > 5f);
            Console.WriteLine($"\nNumber of cats: {cats}");
            Console.WriteLine($"\nNumber of heavy dogs: {heavyDogs}");
        }

        public static void ContainsExample()
        {
            IEnumerable<Pet> pets = Data.Pets;
            Printer<Pet>.PrintEnumerable(pets, nameof(pets));
            Pet taiga = new Pet(4, "Taiga", PetType.Dog, 35f);
            bool taigaPresent = pets.Contains(taiga, new PetComparer());
            Console.WriteLine($"\nTaiga is present: {taigaPresent}");
        }

        public static void OrderbyExample()
        {
            IEnumerable<Pet> pets = Data.Pets;
            Printer<Pet>.PrintEnumerable(pets, nameof(pets));
            IOrderedEnumerable<Pet> sortedByName = pets.OrderBy(pet => pet.Name);
            Printer<Pet>.PrintEnumerable(sortedByName, nameof(sortedByName));

            IOrderedEnumerable<Pet> byTypeAndName = pets
                .OrderBy(pet => pet.PetType)
                .ThenBy(pet => pet.Name);
            Printer<Pet>.PrintEnumerable(byTypeAndName, nameof(byTypeAndName));

            IOrderedEnumerable<Pet> byType = pets.OrderBy(pet => pet, new PetTypeComparer());
            Printer<Pet>.PrintEnumerable(byType, nameof(byType));

            IEnumerable<Pet> reversed = pets.Reverse();
            Printer<Pet>.PrintEnumerable(reversed, nameof(reversed));
        }

        public static void MinMaxAvgSumExample()
        {
            IEnumerable<Pet> pets = Data.Pets;
            Printer<Pet>.PrintEnumerable(pets, nameof(pets));

            double maxWeight = pets.Max(pet => pet.Weight);
            Printer<double>.PrintVariable(maxWeight, nameof(maxWeight));

            int shortName = pets.Min(pet => pet.Name.Length);
            Printer<int>.PrintVariable(shortName, nameof(shortName));

            double avgWeight = pets.Average(pet => pet.Weight);
            Printer<double>.PrintVariable(avgWeight, nameof(avgWeight));

            double allWeight = pets.Sum(pet => pet.Weight);
            Printer<double>.PrintVariable(allWeight, nameof(allWeight));
        }

        public static void ElementAtFirstLastExample()
        {
            // OrDefault versions of these methods doesn't throw exception if invalid, returns default value;
            IEnumerable<int> numbers = new[] { 11, 12, 2, 21, 33, 43, 22, 5, 15, 27, 21, 10, 20, 31, 7 };
            Printer<int>.PrintEnumerable(numbers, nameof(numbers));

            Console.WriteLine(numbers.Count());
            
            int fourth = numbers.ElementAt(3);
            Printer<int>.PrintVariable(fourth, nameof(fourth));

            int sixth = numbers.ElementAtOrDefault(50);
            Printer<int>.PrintVariable(sixth, nameof(sixth));

            int firstEven = numbers.First(number => number % 2 == 0);
            Printer<int>.PrintVariable(firstEven, nameof(firstEven));

            int greaterThan100 = numbers.FirstOrDefault(number => number > 100);
            Printer<int>.PrintVariable(greaterThan100, nameof(greaterThan100));

            int lastEven = numbers.Last(number => number % 2 == 0);
            Printer<int>.PrintVariable(lastEven, nameof(lastEven));

            greaterThan100 = numbers.LastOrDefault(number => number > 100);
            Printer<int>.PrintVariable(greaterThan100, nameof(greaterThan100));
        }
        
    }
}
