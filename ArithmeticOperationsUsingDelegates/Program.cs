
// Write a Program to Implement Arithmetic Operations using Delegates

namespace ArithmeticOperationsUsingDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputOutput inputOutput = new InputOutput();
            // Asking user to choose an option
            Console.WriteLine("Choose the option: \nAddition - 1 \nSubtraction - 2 \nMultiplication -3 \nDivision - 4");
            int option=int.Parse(Console.ReadLine());

            // based on the option choosen by user, operations will be executed
            switch (option)
            {
                case 1:inputOutput.add();                      // points to the add method in InputOutput class
                    break;
                case 2:inputOutput.subtract();                 // points to the subtract method in InputOutput class
                    break;
                case 3:inputOutput.multiply();                 // points to the multiply method in InputOutput class
                    break;
                case 4:inputOutput.divide();                   // points to the divide method in InputOutput class
                    break;
                default:
                    Console.WriteLine("Choosen wrong option"); // prints error for invalid option choosen
                    break;
            }

        }
    }
}
