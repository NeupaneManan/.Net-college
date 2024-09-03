namespace Strings
namespace System.Text;
{
    internal class Program
    {
        static void Main(string[] args) {
            /*string name;
            Console.WriteLine("Enter First Name:");
            name = Console.ReadLine().ToUpper();
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Small" + name.ToLower());
      */

            string word;
            Console.WriteLine("Enter a Word:");
            word = Console.ReadLine();  
            Console.WriteLine(ReverseString(word));
            Console.ReadKey();
        }
        static string ReverseString(string word)
        {
            StringBuilder b = new StringBuilder("");
            for (int i = 0; i < word.Length; i++)
            {
                b.Append(word[i]);
            }
            return b.ToString();
        }
    }
}
