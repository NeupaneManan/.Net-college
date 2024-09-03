namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int a = 1;
            int b = 2;

            Console.WriteLine("Before Swapping:");
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After Swapping");
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();

        }
    }
}
