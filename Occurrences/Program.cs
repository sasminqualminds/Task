
// Write a  Program to display OCCURENCES of  each character in a STRING

namespace Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking user to enter a string
            Console.WriteLine("Enter your string:");
            string userInput = Console.ReadLine();

            // Loop through each character in the string
            for (int i = 0; i < userInput.Length; i++)
            {
                bool counted = false;                                 // Check if the character has been counted
                for (int j = 0; j < i; j++)
                {
                    if (userInput[i] == userInput[j])
                    {
                        counted = true;
                        break;
                    }
                }
                if (counted)                                          // If the character has already been counted, skip it
                {
                    continue;
                }
                int count = 0;
                for (int j = 0; j < userInput.Length; j++)          // Loop through the string to count occurrences
                {
                    if (userInput[i] == userInput[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Character '{userInput[i]}' occurs {count} times.");  // Print the count of the character
            }



            /* ----------

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char i in str)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict[i] = 1;
                }
            }
            foreach (var pair in dict)
            {
                Console.WriteLine($" {pair.Key} : {pair.Value} ");
            }
        
        
            ----------*/

        }


        
    }
}
