
// Program to Convert Characters of a String to Opposite Case
namespace OppositeCase
{
    internal class Program
    {

        // A - 65 to Z - 90
        // a - 97 to z - 122
        /* Here the difference between Upper case and Lower case of each character is always 32  */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text");
            string text = Console.ReadLine();

            string caseConversionOfText = "";
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (currentChar >= 'a' && currentChar <= 'z')
                {
                    caseConversionOfText += (char)(currentChar - 32); // Convert lowercase to uppercase
                }
                else if (currentChar >= 'A' && currentChar <= 'Z')
                {
                    caseConversionOfText += (char)(currentChar + 32); // Convert uppercase to lowercase
                }
                
            }
            Console.WriteLine("By converting the case of each charcter :"+ caseConversionOfText);
        }
    }
}
