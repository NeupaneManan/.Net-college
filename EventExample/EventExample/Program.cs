using Microsoft.Win32;

namespace EventExample
{
    internal class Program
    {
        public delegate void PersonDelegate();

        public class Person
        {
            public event PersonDelegate? NameChanged;

            public string name = null!;
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    if(NameChanged != null) //if event is subscribed by the user 
                    {
                        NameChanged();
                    }
                    name = value;
                }

            }
        }
     public static void Main(string[] args)
        {
           Person p = new Person();
            p.NameChanged += Name_Changed;
            p.Name = "Test";
            Console.WriteLine($"HELLO {p.Name}, How are You?");
            p.name = "Goman";
        }

     public static void Name_Changed()
        {
            Console.WriteLine("Hey!! You changed My name");
        }
    } 
}
