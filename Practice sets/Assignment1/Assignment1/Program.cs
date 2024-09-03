using System.Diagnostics.CodeAnalysis;

namespace Assignment1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number:");
            int a = Convert.ToInt32(args[]);
            Console.WriteLine("Enter second Number: ");
            int b = Convert.ToInt32(args[]);
            int sum = a + b;
            Console.WriteLine(sum);
           }
    }
}
