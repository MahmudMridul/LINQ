
using LINQ.Utils;
using System.Collections;

namespace LINQ.Examples.Methods
{
    public class Cast
    {
        public static void Run()
        {
            // Converting non-generic to strongly-typed  
            ArrayList nums = new ArrayList() { 5, 1, 2, 11 };
            IEnumerable<int> stringNums = nums.Cast<int>();
            Printer.Print(stringNums, nameof(stringNums));

            List<Animal> animals = new List<Animal>()
            {
                new Dog("A"),
                new Cat("B"),
                new Dog("C"),
                new Cat("D"),
                new Dog("E"),
                new Dog("F"),
            };

            // Get only dogs and convert them to Dog type
            IEnumerable<Dog> dogs = animals.Where(animal => animal is Dog).Cast<Dog>();
            Printer.Print(dogs, nameof(dogs));
        }

        public class Animal(string name)
        {
            public string Name { get; set; } = name;
        }

        public class Dog(string name) : Animal(name)
        {
            
        }

        public class Cat(string name) : Animal(name)
        {

        }
    }
}
