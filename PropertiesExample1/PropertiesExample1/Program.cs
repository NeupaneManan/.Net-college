using System.Net.NetworkInformation;

namespace PropertiesExample1
{
    public class Person
    {

        // -------Short hand technique for properties where we cannot apply condition ----------------
        public string name { get; set;}

        public string address { get; set; }

        public int id { get; set; }


        /*  ------------- Properties ------------------------
        public string Name
        {
            get
            {
              
                return name;
            }

            set
            {
                if (value.Length > 1)+
                {
                    name = value;
                }
                else
                {
                    name = "No Name";
                }
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                if(value.Equals("Iatahri")|| value.Equals("Dharan")|| value.Equals("Biratnagar"))
                {
              address = value;
                }
                else
                {
                    Console.WriteLine("Inavlid Address");
                    address = "Inaruwa";
                }
            }*/

            /*public string getname()
            {
                return name;
            }
            public string setName(string n)
            {
                name = n;
            }

            public string getaddress()
            {
                return address;
            }
            public string setAddress(string n)
            {
                    if(n.Equals("Itahari")||)
                name = n;
            }*/
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                Person p = new Person();
                /*  p.setName("Bhojraj");
                  p.setAddress("Itahari");
                  Console.WriteLine($"{p.getname()} lives in {p.getaddress()}");
                */

                p.name = "M";
                p.address = "Kathmandu";
                Console.WriteLine($"{p.name} lives in {p.address} your id is {p.id}");
                Console.ReadKey();
            }
        }
    }
