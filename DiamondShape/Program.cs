
// Write a program to display NUMBERS in DIAMOND shape
/*    1
     121
    12321
   1234321
    12321
     121
      1          */


using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiamondShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking the user to enter an number
            Console.WriteLine("Enter a number");
            int number =int.Parse(Console.ReadLine());

            // for upper triangle
            for (int i= 1; i <= number; i++)                             
            {
                for (int j = 1; j <= number - i; j++)                  // for spaces  example:                                                                      
                {
                    Console.Write(" ");                                /*    ...
                                                                        *    ..
                                                                        *    .                   */
                }
                
                for (int j = 1; j <= i; j++)                            // for numbers of left side upper triangle ex: 
                {
                    Console.Write(j);                                   /*          1
                                                                         *          12
                                                                         *          123
                                                                         *          1234          */
                } 

                for (int j = i-1; j >=1; j--)                            // for numbers of right side upper triangle  ex:
                {
                    Console.Write(j);                                    /*            
                                                                          *            1
                                                                          *            21
                                                                          *            321         */
                }

                Console.WriteLine();
            }

            // for lower triangle
            for (int i = 1; i < number; i++)
            {

                for (int j = 1; j <= i ; j++)                              // for spaces
                {
                    Console.Write(" ");                                    /*   .
                                                                            *   ..
                                                                            *   ...                 */
                }
                for (int j = 1; j <= number - i; j++)                      // for numbers of left side lower triangle
                {
                    Console.Write(j);                                      /*   123
                                                                            *   12
                                                                            *   1                    */
                }

                for (int j = number - i - 1; j >= 1; j--)                  // for numbers of right side lower triangle
                {
                    Console.Write(j);                                      /*   21
                                                                            *   1
                                                                            *                        */
                }
                Console.WriteLine() ;
            }
        }
    }
}
