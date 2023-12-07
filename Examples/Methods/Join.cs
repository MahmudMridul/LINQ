
using LINQ.Utils;

namespace LINQ.Examples.Methods
{
    public class Join : ILinqFunctions
    {
        public void Run()
        {
            Person[] people = Data.people;
            Student[] students = Data.students;

            var studentDetail = students.Join(
                    people,
                    student => student.NID,
                    person => person.NID,
                    (student, person) => $"Name: {person.Name} Age: {person.Age} Profession: {person.Profession} Major: {student.Major} Marks: {student.MarksPercentage}"
                );
            Printer.Print(studentDetail, nameof(studentDetail));

            var studentDetailQuery = from person in people
                                     join student in students
                                     on person.NID equals student.NID
                                     select $"Name: {person.Name} Age: {person.Age}  Major: {student.Major} Marks: {student.MarksPercentage}";
            Printer.Print(studentDetailQuery, nameof(studentDetailQuery));
        }
    }
}
