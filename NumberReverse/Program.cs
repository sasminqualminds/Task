
// Write a program to REVERSE the number

namespace NumberReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking the user to enter a number
            Console.WriteLine("Enter your num");
            int number = Convert.ToInt32(Console.ReadLine());
            string reverse = "";
            int reverseNumber;

            // checking condition if the number is zero
            if (number == 0){
                Console.WriteLine("By reversing the number you get: 0 ");
            };

             
            while (number != 0)                                 // checking if the number is not equal to 0
            {                              
                int remainder = number % 10;                    // taking the remainder of that number which will be the last digit
                reverse = reverse + remainder;                      // adding that digit to an empty string
                number = number / 10;                           // dividing the number so that the last digit will be removed
            }                                                   // checking the condition until the number is not equal to 0
            
            reverseNumber=int.Parse(reverse);                   // converting the string "reverse" to an integer type
            Console.WriteLine("By reversing the number you get :" + reverseNumber);
            Console.ReadKey();
        }
    }
}
