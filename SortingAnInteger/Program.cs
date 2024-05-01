
// Sort an integer array without using Inbuilt functions.

namespace SortingAnInteger
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            // Asking user to enter the length of the array
            Console.WriteLine("number of element you want to add into an array");
            int numberOfElements=Convert.ToInt32(Console.ReadLine());
            int[] numberArray = new int[numberOfElements];

            // adding the elements to the array
            for(int item =0; item < numberOfElements; item++)
            {
                Console.WriteLine($"Enter your {item+1} element");
                
                numberArray[item]= Convert.ToInt32(Console.ReadLine());

            }

            // printing the elements of array before sorting 
            Console.WriteLine("Array elements before sorting:");
            foreach (int item in numberArray)
            {               
                Console.Write(item+" ");
            }

            // sorting the elements in ascending order
            for (int item1 = 0; item1 < numberOfElements-1; item1++)
            {
                for(int item2 = 0; item2 < numberOfElements-item1-1; item2++)
                {
                    if (numberArray[item2] > numberArray[item2 + 1])
                    {
                        int temp = numberArray[item2];
                        numberArray[item2]= numberArray[item2 + 1];
                        numberArray[item2 + 1] = temp;
                    }
                }
            }
            Console.WriteLine();

            // printing the elements in array after sorting
            Console.WriteLine("Array elements after sorting:");
            foreach(int element in numberArray)
            {
                Console.Write(element + " ");
            }

            Console.ReadKey();
        }
    }
}
