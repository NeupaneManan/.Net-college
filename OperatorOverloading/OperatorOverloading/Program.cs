//// VVIP 2

using System.Reflection.Metadata.Ecma335;

namespace OperatorOverloading
{
    public class Distance
    {
        private int meter;
        private int centimeter;

        public Distance()
        {
            meter = 0;

            centimeter = 0;
        }
        public Distance(int meter, int centimeter)
        {
            this.meter = meter;

            this.centimeter = centimeter;

        }

       /* public static Distance AddDistance(Distance d1, Distance d2)
        {
            Distance d3 = new Distance();
            d3.centimeter = (d1.centimeter + d2.centimeter) % 100;
            d3.meter = d1.meter + d2.meter + (d2.centimeter + d2.centimeter) / 100;
            return d3;
        }*/

        public static Distance operator+(Distance d1, Distance d2)
        {
            Distance d3 = new Distance();
            d3.centimeter = (d1.centimeter + d2.centimeter) % 100;
            d3.meter = d1.meter + d2.meter + (d2.centimeter + d2.centimeter) / 100;
            return d3;
        }

        public static Distance operator++(Distance d)
        {
            return new Distance (d.meter + 1, d.centimeter);
        }

        public static void display(Distance d)
        {
            Console.WriteLine($"The Distance is {d.meter}m and {d.centimeter} cm");
        }
        internal class Program
        {

            static void Main(string[] args)
            {
                Distance d1 = new Distance(12, 63);
                Distance d2 = new Distance(46, 87);
                Distance d3 = d1 + d2; //To do this you should use operator+ in method.
                Distance.display(d3);
                Distance.display(++d3);
            }
        }
    }
}

//operator overloading garda method static hunai parxa
//return type same hunxaaaa 

