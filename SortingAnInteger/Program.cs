namespace SortingAnInteger
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            // taking elements from user
            Console.WriteLine("number of element you want to add into an array");
            int numOfElements=Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[numOfElements];
            for(int item =0; item < numOfElements; item++)
            {
                Console.WriteLine($"Enter your {item} element");
                
                intArray[item]= Convert.ToInt32(Console.ReadLine());

            }
            // printing the elements in array before sorting 
            Console.WriteLine("Array elements before sorting:");
            foreach (int i in intArray)
            {               
                Console.Write(i+" ");
            }
            // sorting the elements in ascending order
            for (int i = 0; i < numOfElements-1; i++)
            {
                for(int j = 0; j < numOfElements-i-1; j++)
                {
                    if (intArray[j] > intArray[j+1])
                    {
                        int temp = intArray[j];
                        intArray[j]= intArray[j+1];
                        intArray[j+1] = temp;
                    }
                }
            }
            Console.WriteLine();
            // printing the elements in array after sorting
            Console.WriteLine("Array elements after sorting:");
            foreach(int i in intArray)
            {
                Console.Write(i + " ");
            }
        }
    }
}
