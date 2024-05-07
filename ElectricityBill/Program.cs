
/* Write a program to calculate and print the electricity bill of a customer. From the keyboard, the customer's name, ID, and unit consumed should be taken and displayed along with the total amount due.
   upto 199  Units                               $ 8.20
   200 and above but less than 400  Units        $ 10.50
   400 and above but less than 600  Units        $ 13.80
   600 and above   Units                         $ 16.00
*/



namespace ElectricityBill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking user to enter a name
            Console.WriteLine("Enter customer's name");
            string customerName=Console.ReadLine();
            // Asking user to enter id
            Console.WriteLine("Enter customer's id");
            int customerId=Convert.ToInt32(Console.ReadLine());
            // Asking user to enter the unit's consumed
            Console.WriteLine("Enter unit's consumed?");
            double unitConsumed=Convert.ToDouble(Console.ReadLine());
            // Displaying the user details and the total due amount
            Console.WriteLine($"Below are the customer details : \nCustomer name is : {customerName} \nCustomer id is : {customerId} \nUnit's consumed is :{unitConsumed}");
            if(unitConsumed > 0 && unitConsumed<200)
            {
                Console.WriteLine($"Total amount due is : $ {(unitConsumed * 8.20).ToString("0.00")}");
            }
            else if (unitConsumed > 200 && unitConsumed < 400)
            {
                Console.WriteLine($"Total amount due is : $ {(unitConsumed * 10.50).ToString("0.00")}");
            }
            else if(unitConsumed >400 &&  unitConsumed < 600)
            {
                Console.WriteLine($"Total amount due is : $ {(unitConsumed * 13.80).ToString("0.00")}");
            }
            else
            {
                Console.WriteLine($"Total amount due is : $ {(unitConsumed *16.00).ToString("0.00")}");
            }
        }
    }
}
