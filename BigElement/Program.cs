namespace BigElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // taking elements from user
            Console.WriteLine("number of element you want to add into an array");
            int numOfElements = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[numOfElements];
            for (int item = 0; item < numOfElements; item++)
            {
                Console.WriteLine($"Enter your {item} element");

                intArray[item] = Convert.ToInt32(Console.ReadLine());

            }
            // printing the elements in array before sorting 
            Console.WriteLine("Array elements before sorting:");
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }

            for(int i = 0; i < numOfElements; i++)
            {
                for(int j=1; j < intArray.Length; j++)
                {
                    if (intArray[0] < intArray[j])
                    {
                        intArray[0] = intArray[j];
                        
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("largest element in array is "+ intArray[0]);
           
        }
    }
}
