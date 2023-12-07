namespace LINQ.Utils
{
    public static class Data
    {
        public static int[]? nullNums = null;
        public static int[] emptyNums = { };
        public static int[] nums = { 54, 28, 73, 11, 92, 67, 5, 39, 88, 16, 81, 43, 76, 22, 98 };
        public static string[] names = { "Alice", "Bob", "Charlie", "David", "Eva", "Frank", "Grace", "Hannah", "Ian", "Olivia" };

        public static Student[] students = {
            new Student(1016, "Lena", "CSE", 80),
            new Student(1017, "Ethan", "EEE", 75),
            new Student(1018, "Sophie", "BBA", 78),
            new Student(1019, "Lucas", "EEE", 90),
            new Student(1020, "Aria", "Physics", 93),
        };

        public static Person[] people = {
            new Person(101, "Alice", "Engineer", 30, "Single"),
            new Person(102, "Bob", "Doctor", 35, "Married"),
            new Person(103, "Charlie", "Teacher", 25, "Single"),
            new Person(104, "David", "Lawyer", 28, "Married"),
            new Person(105, "Eva", "Artist", 32, "Single"),
            new Person(106, "Frank", "Engineer", 40, "Single"),
            new Person(107, "Grace", "Doctor", 45, "Married"),
            new Person(108, "Hannah", "Chef", 27, "Single"),
            new Person(109, "Ian", "Teacher", 29, "Married"),
            new Person(1010, "Julia", "Artist", 31, "Single"),
            new Person(1011, "Kevin", "Engineer", 33, "Married"),
            new Person(1012, "Lily", "Artist", 26, "Single"),
            new Person(1013, "Mike", "Lawyer", 38, "Married"),
            new Person(1014, "Nora", "Chef", 29, "Single"),
            new Person(1015, "Olivia", "Doctor", 36, "Single"),
            new Person(1016, "Lena", "Student", 18, "Single"),
            new Person(1017, "Ethan", "Student", 20, "Single"),
            new Person(1018, "Sophie", "Student", 19, "Single"),
            new Person(1019, "Lucas", "Student", 20, "Single"),
            new Person(1020, "Aria", "Student", 21, "Single"),
            new Person(1021, "Morgan", "Student", 21, "Single"),
            new Person(1022, "Warner", "Student", 18, "Single"),

        };

    }
}
