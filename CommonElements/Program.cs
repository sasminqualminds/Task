
// Write a program to DISPLAY THE COMMON ELEMENTS between two arrays.

using System.Collections;

namespace CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking user to enter the number of elements he want to add into an array1
            Console.WriteLine("number of element you want to add into an array1");
            int numberOfElementsInArray1 = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[numberOfElementsInArray1];

            // Asking user for each element and storing it in array1
            for (int i = 0; i < numberOfElementsInArray1; i++)
            {
                Console.WriteLine($"Enter your element {i + 1} ");

                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Asking user to enter the number of elements he want to add into an array2
            Console.WriteLine("number of element you want to add into an array2");
            int numberOfElementsInArray2 = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int[numberOfElementsInArray2];

            // Asking user for each element and storing it in array
            for (int item = 0; item < numberOfElementsInArray2; item++)
            {
                Console.WriteLine($"Enter your element {item + 1} ");

                array2[item] = Convert.ToInt32(Console.ReadLine());
            }

            // printing the common elements to console
            Console.WriteLine("Common elements:");

            // looping through each element in array1
            for (int i = 0; i < array1.Length; i++)
            {
                int currentElement = array1[i];

                // checking if the current element is already found
                bool alreadyFound = false;

                for (int j = 0; j < i; j++)
                {
                    if (array1[j] == currentElement)
                    {
                        alreadyFound = true;
                        break;
                    }

                }
                if (alreadyFound)
                {
                    continue;
                }

                // checking if the current element is in array2
                for (int k = 0; k < array2.Length; k++)
                {
                    if (currentElement == array2[k])
                    {
                        Console.WriteLine(array2[k]);
                        break;
                    }
                }

            }



            /*--------- for non repeating of elements ------------*/

            //// Loop through each element of array1
            //foreach (int num1 in array1)
            //{
            //    // Compare each element of array1 with elements of array2
            //    foreach (int num2 in array2)
            //    {
            //        // If a common element is found, print it
            //        if (num1 == num2)
            //        {
            //            Console.WriteLine(num1);
            //            break; // Break the inner loop to avoid duplicate printing
            //        }
            //    }
            //}

        }
    }
}
