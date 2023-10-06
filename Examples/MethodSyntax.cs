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
            PrintPets();
            bool nameLength = pets.Any(pet => pet.Name.Length > 5);
            Console.WriteLine($"Name lenght more than 5: {nameLength}");
        }

        public static void AllExample()
        {
            IEnumerable<Pet> pets = Data.Pets;
            PrintPets();
            bool allCat = pets.All(pet => pet.PetType == PetType.Cat);
            Console.WriteLine($"All cat: {allCat}");
        }

        public static void CountExample()
        {
            IEnumerable<Pet> pets = Data.Pets;
            PrintPets();
            int cats = pets.Count(pet => pet.PetType == PetType.Cat);
            long heavyDogs = pets.LongCount(pet => pet.PetType == PetType.Dog && pet.Weight > 5f);
            Console.WriteLine($"\nNumber of cats: {cats}");
            Console.WriteLine($"\nNumber of heavy dogs: {heavyDogs}");
        }

        public static void ContainsExample()
        {
            IEnumerable<Pet> pets = Data.Pets;
            PrintPets();
            Pet taiga = new Pet(4, "Taiga", PetType.Dog, 35f);
            bool taigaPresent = pets.Contains(taiga, new PetComparer());
            Console.WriteLine($"\nTaiga is present: {taigaPresent}");
        }

        private static void PrintPets()
        {
            IEnumerable<Pet> pets = Data.Pets;
            Console.WriteLine("\nPets: \n");
            foreach (Pet pet in pets)
            {
                Console.WriteLine(pet);
            }
            Console.WriteLine("\n======X=====\n");
        }
    }
}
