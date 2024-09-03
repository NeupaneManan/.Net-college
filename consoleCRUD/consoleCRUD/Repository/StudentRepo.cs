using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consoleCRUD.Models;
namespace consoleCRUD.Repository
{
    public static class StudentRepo
    {
        private static List<consoleCRUD.Models.Student> stdList = new();
        public static List<Student> GetStudentList()
        {
            return stdList;
        }
        public static bool AddStudnet(Student s)
        {
            stdList.Add(s);
            return true;
        }
        public static bool DeleteStudent(string name)
        {
            Student? student = stdList.Where(s => s.Name.Equals(name)).FirstOrDefault();
            if (student != null)
            {
                stdList.Remove(student);
                return true;
            }
            else
                return false;
        }
        public static bool UpdateStudent(int id, Student s)
        {
            Student? student = stdList.Where(s => s.Id == id).FirstOrDefault();
            if (student != null)
            {
                student.Name = s.Name;
                student.Address = s.Address;
                student.Phone = s.Phone;
                return true;
            }
            return false;
        }
    }
}