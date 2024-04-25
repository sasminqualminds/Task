using System.Collections;

namespace RemoveDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            
            // taking elements from user
            Console.WriteLine("number of element you want to add into an array");
            int numOfElements = Convert.ToInt32(Console.ReadLine());
            int[] empty; ;
            int[] intArray = new int[numOfElements];
            for (int item = 0; item < numOfElements; item++)
            {
                Console.WriteLine($"Enter your {item} element");

                intArray[item] = Convert.ToInt32(Console.ReadLine());

            }
           
            // count of each number
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int i in intArray)
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
            HashSet<int> set = new HashSet<int>(intArray);
            empty = set.ToArray();
            foreach(int i in empty)
            {
                Console.WriteLine(i);
            }


           

        }
    }
}
