
// Print the big element in the integer array.

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BigElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking user to enter the number of elements he want to add into an array
            Console.WriteLine("number of element you want to add into an array");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());
            int[] numberArray = new int[numberOfElements]; 

            // Asking user for each element and storing it in array
            for (int item = 0; item <numberOfElements; item++)
            {
                Console.WriteLine($"Enter your element {item+1} ");

                numberArray[item] = Convert.ToInt32(Console.ReadLine());
            }

            // printing the elements of array
            Console.WriteLine("Array elements");
            for(int i=0; i < numberArray.Length; i++)
            {
                Console.Write(numberArray[i] + " ");
            }
            
            // Comparing the first element with other elements and storing the largest element at index 0
            for(int i = 0; i < numberOfElements; i++)
            {
                for(int j=1; j < numberArray.Length; j++)
                {
                    if (numberArray[0] < numberArray[j])
                    {
                        numberArray[0] = numberArray[j];
                        
                    }
                }
            }
            Console.WriteLine();

            // Printing the largest element i.e., the first number at 0th index
            Console.WriteLine("largest element in array is "+ numberArray[0]);
            Console.ReadKey();
           
        }
    }
}
