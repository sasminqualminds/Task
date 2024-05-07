
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
           
            int reverseNumber=0;

            // checking condition if the number is zero
            if (number == 0){
                Console.WriteLine("By reversing the number you get: 0 ");
                
            }
            else
            {
                while (number != 0)                                 // checking if the number is not equal to 0
                {
                    int remainder = number % 10;                    // taking the remainder of that number which will be the last digit
                    reverseNumber = reverseNumber * 10 + remainder; // adding that digit to a integer
                    number = number / 10;                           // dividing the number so that the last digit will be removed
                }                                                   // checking the condition until the number is not equal to 0

                Console.WriteLine("By reversing the number you get :" + reverseNumber);
            }

             
            
            Console.ReadKey();
        }
    }
}
