using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace ConsoleWithDbCrud
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
                switch (choice)
                {
                    case '1': Insert(); break;
                    case '2': Remove(); break;
                    case '3': Update(); break;
                    case '4': List(); break;
                    case '5': return;
                }
                Console.ReadKey();
            } while (true);
        }
        public static void Insert()
        {
            Console.WriteLine("Id");
            int id =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name:");
            string name = Console.ReadLine() ;

            Console.WriteLine("Address:");
            string ?address = Console.ReadLine();

            Console.WriteLine("Gender :");
            bool gender;
            while (!bool.TryParse(Console.ReadLine(), out gender))
            {
                Console.WriteLine("Invalid input.:");
            }

            Console.WriteLine("Date of Birth (yyyy-MM-dd):");
            DateOnly date;
            while (!DateOnly.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Invalid date format. Please use yyyy-MM-dd format:");
            }

            Student s = new Student()
            {
                Id = id,
                Name = name,
                Address = address,
                Gender = gender,
                DoB = date
            };

            DataAccess DA = new DataAccess();
            if (DA.AddStudent(s))
            {
                Console.Clear();
                Console.WriteLine("Record added");
            }
            else
            {
                Console.WriteLine("Insertion Failed");
            }

            Console.ReadKey();
        }


        public static void Remove()
        {
            Console.WriteLine("Enter the Id of the student to be removed:");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer Id:");
            }

            DataAccess DA = new DataAccess();
            if (DA.DeleteStudent(id))
            {
                Console.Clear();
                Console.WriteLine("Record removed successfully");
            }
            else
            {
                Console.WriteLine("Removal failed. No record found with the given Id.");
            }

            Console.ReadKey();
        }
        public static void Update()
        {
            Console.WriteLine("Enter the Id of the student to be updated:");
            int oldId;
            while (!int.TryParse(Console.ReadLine(), out oldId))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer Id:");
            }

            Console.WriteLine("Enter the new Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the new Address:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter the new Gender (true for male, false for female):");
            bool gender;
            while (!bool.TryParse(Console.ReadLine(), out gender))
            {
                Console.WriteLine("Invalid input. Please enter true or false:");
            }

            Console.WriteLine("Enter the new Date of Birth (yyyy-MM-dd):");
            DateOnly dob;
            while (!DateOnly.TryParse(Console.ReadLine(), out dob))
            {
                Console.WriteLine("Invalid date format. Please use yyyy-MM-dd format:");
            }

            Student updatedStudent = new Student()
            {
                Id = oldId,
                Name = name,
                Address = address,
                Gender = gender,
                DoB = dob
            };

            DataAccess DA = new DataAccess();
            if (DA.UpdateStudent(updatedStudent, oldId))
            {
                Console.Clear();
                Console.WriteLine("Record updated successfully");
            }
            else
            {
                Console.WriteLine("Update failed. No record found with the given Id.");
            }

            Console.ReadKey();

        }
        public static void List()
        {
            Console.Clear();
            Console.WriteLine($"Id \t Name \t Address \tGender \t Date Of Birth");
            DataAccess data = new DataAccess();
            List <Student> list =data.GetStudentList();
            foreach (Student s in list)
            {
                Console.WriteLine($"{s.Id} \t{s.Name}\t {s.Address}\t{s.Gender}\t {s.DoB}");
            }
            Console.ReadKey();
        }
    }
}

