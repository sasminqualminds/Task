
// Write a program to display the FILLED BOX with stars, enter value of n=7

namespace Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 5;

            // Asking the user to enter the value of n
            Console.WriteLine("enter the value");          
            int column = int.Parse(Console.ReadLine());
            
            // looping for each row with column index
            for(int i = 0; i < row; i++)
            {
                for(int j=0;j< column; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}
