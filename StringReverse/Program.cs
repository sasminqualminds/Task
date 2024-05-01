
// Reverse the string without using Inbuilt functions.

namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking user to enter a string
            Console.WriteLine("Enter your string");
            string userInput=Console.ReadLine();
            
            // looping the string from last to first
            for(int i= userInput.Length-1;i>=0; i--)
            {
                Console.Write(userInput[i]);
            }
            Console.ReadKey();
            
        }
    }
}
