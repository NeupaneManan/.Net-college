using System;
namespace Practice_sets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            int num1, num2, sum;
            Console.WriteLine("Enter First Number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum =  num1 + num2;
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " = " + sum); 
            Console.ReadKey();
        }
    }
}
