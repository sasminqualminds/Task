
// Write a Program to Find All Substrings in a String

namespace Substrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking user to enter a text
            Console.WriteLine("Enter your text");
            string text=Console.ReadLine();
            // declaring an empty string
            string subText = "";
            // printing all the substrings that can be formed in the given text
            Console.WriteLine("All substrings that can be formed in your text are:");
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = i; j < text.Length; j++)
                {
                    subText = subText + text[j];
                    Console.Write(subText + ",");                   
                }
                subText = "";
            }
        }
    }
}
