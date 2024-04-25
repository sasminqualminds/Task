namespace NumberReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your num");

            int num1 = Convert.ToInt32(Console.ReadLine());
            string empty = "";
            while (num1 != 0)
            {               
                Console.WriteLine(num1);
                int num = num1 % 10;               
                empty=empty + num;
                num1=num1/ 10;
            }
            Console.WriteLine(empty);
           
        }
    }
}
