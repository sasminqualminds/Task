
// Print the elements with no of times it repeated in the array and remove duplicate elements from an Array

using System.Collections;

namespace RemoveDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Asking user how many elements he want to add into an array
            Console.WriteLine("number of element you want to add into an array");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());

            // taking the elements from user and storing it into an array
            int[] array = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine($"Enter your {i+1} element");

                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            
            // looping through each element of array
            Console.WriteLine("Number : countOfNumber");
            for (int i=0; i < numberOfElements; i++)          
            {
                int countOfNumber = 1;
                if(array[i] != -1 ) {
                    for(int j=i+1;j<numberOfElements; j++)
                    {
                        if (array[i] == array[j])
                        {
                            countOfNumber++;
                            array[j] = -1;
                        }
                    }
                    Console.WriteLine($"{array[i]} : {countOfNumber}");
                }
            }

            // printing the array elements with duplicates removed
            Console.WriteLine(" Array elements after removing duplicates:");
            for(int i=0;i<numberOfElements; i++)
            {
                if (array[i] != -1 )
                {
                    Console.Write(array[i] + ",");
                }
            }


            /*------------------- using built-in 
           
            // count of each number
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int i in array)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                    Console.WriteLine(dict[1]);
                }
                else
                {
                    dict.Add(i, 1);
                }

            }
            foreach(var pair in dict)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
            // unique elements
            HashSet<int> set = new HashSet<int>(array);
            empty = set.ToArray();
            foreach(int i in empty)
            {
                Console.WriteLine(i);
            }

            --------------------------------*/
           

        }
    }
}
