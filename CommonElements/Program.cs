using System.Collections;

namespace CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 4, 2 };
            int[] a2 = { 1, 4, 6, 8 };
            List<int> values = new List<int>();
            int count=0;
            foreach(int item in a1)
            {
                if (a2.Contains(item))
                {
                    values.Add(item);
                    
                }
            }
            foreach(int item in values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
