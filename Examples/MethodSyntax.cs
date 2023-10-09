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
        
    }
}
