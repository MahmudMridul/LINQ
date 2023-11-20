namespace LINQ.Utils
{
    public class Person
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
