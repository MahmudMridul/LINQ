
namespace LINQ.Utils
{
    public class Student
    {
        public int NID { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public int MarksPercentage { get; set; }

        public Student(int nid, string name, string major, int marksPercentage)
        {
            NID = nid;
            Name = name;
            Major = major;
            MarksPercentage = marksPercentage;

        }
    }
}
