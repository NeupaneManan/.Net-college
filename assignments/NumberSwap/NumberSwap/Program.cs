namespace NumberSwap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 13;
            int c;

            Console.Clear();
            Console.WriteLine("Before Swapping");
            Console.WriteLine(a); 
            Console.WriteLine(b);


            Console.WriteLine("After Swapping");
            c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
