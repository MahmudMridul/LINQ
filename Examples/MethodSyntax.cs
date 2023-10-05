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
            Console.WriteLine("Pets: \n");
            foreach (Pet pet in pets)
            {
                Console.WriteLine(pet);
            }
            Console.WriteLine("=====X===== \n");

            bool nameLength = pets.Any(pet => pet.Name.Length > 5);
            Console.WriteLine($"Name lenght more than 5: {nameLength}");
        }

        public static void AllExample()
        {
            IEnumerable<Pet> pets = Data.Pets;
            Console.WriteLine("Pets: \n");
            foreach (Pet pet in pets)
            {
                Console.WriteLine(pet);
            }
            Console.WriteLine("======X=====\n");
            bool allCat = pets.All(pet => pet.PetType == PetType.Cat);
            Console.WriteLine($"All cat: {allCat}");
        }
    }
}
