
using LINQ.Utils;

namespace LINQ.Examples.Methods
{
    internal class Select
    {
        public static void Run()
        {
            int[] nums = { 2, 1, 5, 3, 10 };
            //Performs specified operation on each element
            var squaredNums = nums.Select(n => n * n);
            Printer.Print<int>(squaredNums, nameof(squaredNums));

            Person[] students = { 
                new Person(101, "Kamal", "Student", 20, "Single"),
                new Person(102, "Jamal", "Student", 21, "Single"),
                new Person(103, "Dhamal", "Student", 19, "Single"),
                new Person(104, "Mamal", "Student", 22, "Single"),
                new Person(105, "Samal", "Student", 15, "Single"),
            };
            //Creating anonymous type, mofifying object, creating DTOs
            var onlyNameAndID = students.Select(person => new { ID = person.NID, Name = person.Name });
            Printer.Print<Person>(onlyNameAndID, nameof(onlyNameAndID));
        }
    }

    internal class Person
    {
        public int NID { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Age { get; set; }
        public string MaritalStatus { get; set; }

        public Person(int nid, string name, string profession, int age, string maritalStatus) 
        {
            NID = nid;
            Name = name;
            Profession = profession;
            Age = age;
            MaritalStatus = maritalStatus;
        }
    }
}
