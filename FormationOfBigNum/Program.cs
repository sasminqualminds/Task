using System;
using System.Collections;

namespace FormationOfBigNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Askin user to enter a number
            Console.WriteLine("Enter your num");
            int num=Convert.ToInt32(Console.ReadLine());
            int num1 = num;
            int count = 0;
            while (num1 !=0)
            {
                count++;
                Console.WriteLine("count " + count);
                Console.WriteLine(num1);
                num1 = num1 / 10;
                Console.WriteLine(num1);

            }
            // storing each digit in an array
            int[] array = new int[count];
            for(int i=0;i< count; i++)
            {
                array[i] = num % 10;
                num=num/10;
            }
            // sorting array in ascenting order
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            
            
            Array.Reverse(array);
            Console.WriteLine("Largest number that can be formed is :");
            foreach (int i in array)
            {
                Console.Write(i + "");
            }


        }
    }
}
