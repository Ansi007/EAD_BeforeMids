namespace MVC_PRACTICE.Models
{
    public class StudentRepositry
    {
       public static List<Student> students = new List<Student>();
        public static void AddStudent(Student s)
        {
            students.Add(s);
        }
    }
}
