
// Print the number of digits in a given integer what is the biggest number that can form with these digits

using System;
using System.Collections;

namespace FormationOfBigNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking user to enter a number
            Console.WriteLine("Enter your number");
            int number=Convert.ToInt32(Console.ReadLine());
            
            // Assigning the entered number to "number1"
            int number1 = number;
            int numberOfdigits = 0;
            
            // Printing each digit
            while (number1 !=0)
            {
                numberOfdigits++;               
                number1 = number1 / 10;
            }
            
            // printing the number of digits in a number entered by user
            Console.WriteLine("Number of digits " + numberOfdigits);

            // storing each digit in an array
            int[] digitsArray = new int[numberOfdigits];
            for(int i=0;i< numberOfdigits; i++)
            {
                digitsArray[i] = number % 10;
                number=number/10;
            }

            // sorting array in ascending order
            for (int i = 0; i < numberOfdigits - 1; i++)
            {
                for (int j = 0; j < numberOfdigits - i - 1; j++)
                {
                    if (digitsArray[j] > digitsArray[j + 1])
                    {
                        int temp = digitsArray[j];
                        digitsArray[j] = digitsArray[j + 1];
                        digitsArray[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();

            // Printing the elements of an array from last to first
            Console.WriteLine("Largest number that can be formed with these digits :");
            for (int i = numberOfdigits - 1; i >= 0; i--)
            {
                Console.Write(digitsArray[i]);
            }


            //or by taking the digits of an array from last to first and adding it to an empty string
            // string emptyString = "";
            // for (int i = numberOfdigits - 1; i >= 0; i--)
            //{
            //    emptyString = emptyString + digitsArray[i];
            //}

            //int ConvertingIntoInt = int.Parse(s);
            //Console.WriteLine(ConvertingIntoInt);
            Console.ReadKey();


        }
    }
}
