using consoleCRUD.Models;
using consoleCRUD.Repository;

using System;
using System.Data;
namespace consoleCRUD
{
    public class Program
    {
       public static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Select Your Choice:\n");
                Console.WriteLine("1.Register New Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. Update Student Info");
                Console.WriteLine("4. List Students");
                Console.WriteLine("5.Exit Program");
                char choice = Console.ReadKey().KeyChar;
                switch (choice) {
                    case '1':Insert(); break;
                    case '2':Remove(); break;
                    case '3':Update(); break;
                    case '4':List(); break;
                    case '5': return;
                }
                Console.ReadKey();
            } while (true);
        }
        public static void Insert()
        {
            Student newStd = new Student();
            Console.WriteLine();
            Console.WriteLine("User Registration");
            Console.WriteLine("Name:");
            newStd.Name = Console.ReadLine()??"";
            Console.WriteLine("Address:");
            newStd.Address = Console.ReadLine();
            Console.WriteLine("Phone:");
            newStd.Phone = Console.ReadLine();
            if(StudentRepo.GetStudentList().Count > 0)
            newStd.Id = StudentRepo.GetStudentList().Max(s=>s.Id)+1;
            else
            newStd.Id = 100;
            if (StudentRepo.AddStudnet(newStd))
                Console.WriteLine("Registration Sucessful");
            else
                Console.WriteLine("Registration Failed");
        }

        public static void Remove()
        {
            Console.WriteLine();
            Console.WriteLine("Remove Student:");
            Console.WriteLine("Name");
            string name = Console.ReadLine() ?? string.Empty;
            if (StudentRepo.DeleteStudent(name))
                Console.WriteLine("Student Removed");
            else Console.WriteLine("Removal Failed!, Please Try Again");
        }
        public static void Update()
        {
            Student s = new();
            Console.WriteLine("Update Student Information:");
            Console.WriteLine("Enter Id of the student you want to modify");
            s.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("New Name:");
            s.Name = Console.ReadLine() ?? "No Name";
            Console.WriteLine("New Address:");
            s.Address = Console.ReadLine();
            Console.WriteLine("New Phone Number:");
            s.Phone = Console.ReadLine();
            if (StudentRepo.UpdateStudent(s.Id, s))
                Console.WriteLine("Upadate Sucessful.");
            else 
                Console.WriteLine("Update Failed");

        }
        public static void List()
        {
            Console.WriteLine();
            Console.WriteLine("List of Students");
            Console.WriteLine("Id\tName of Students\t\tAddress\t\tPhone\t\t");
            foreach(Student s in StudentRepo.GetStudentList())
            {
                Console.WriteLine($"{s.Id}\t{ s.Name}\t\t{ s.Address}\t\t{s.Phone}");
            }
        }
    }
}
