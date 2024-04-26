
// Sort an integer array without using Inbuilt functions.

namespace SortingAnInteger
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            // Asking user to enter the length of the array
            Console.WriteLine("number of element you want to add into an array");
            int numOfElements=Convert.ToInt32(Console.ReadLine());
            int[] integerArray = new int[numOfElements];

            // adding the elements to the array
            for(int item =0; item < numOfElements; item++)
            {
                Console.WriteLine($"Enter your {item+1} element");
                
                integerArray[item]= Convert.ToInt32(Console.ReadLine());

            }

            // printing the elements of array before sorting 
            Console.WriteLine("Array elements before sorting:");
            foreach (int item in integerArray)
            {               
                Console.Write(item+" ");
            }

            // sorting the elements in ascending order
            for (int item1 = 0; item1 < numOfElements-1; item1++)
            {
                for(int item2 = 0; item2 < numOfElements-item1-1; item2++)
                {
                    if (integerArray[item2] > integerArray[item2 + 1])
                    {
                        int temp = integerArray[item2];
                        integerArray[item2]= integerArray[item2 + 1];
                        integerArray[item2 + 1] = temp;
                    }
                }
            }
            Console.WriteLine();

            // printing the elements in array after sorting
            Console.WriteLine("Array elements after sorting:");
            foreach(int element in integerArray)
            {
                Console.Write(element + " ");
            }

            Console.ReadKey();
        }
    }
}
