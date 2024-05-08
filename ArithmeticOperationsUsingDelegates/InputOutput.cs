using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperationsUsingDelegates
{
    internal class InputOutput
    {
        Operations operations=new Operations();
        public delegate int ArithmeticOperationDelegate(int a, int b);                     // Declaring a delegate

        public void add()
        {
            Console.WriteLine("Enter your first number");                                   // Asking user to enter first number
            int firstNumber=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");                                  // Asking user to enter second number
            int secondNumber = int.Parse(Console.ReadLine());
            ArithmeticOperationDelegate arithmeticOperationDelegate = new ArithmeticOperationDelegate(operations.add);      //It points to the add method in Operations class
            int sum= arithmeticOperationDelegate(firstNumber, secondNumber);                

            Console.WriteLine($"Addition of {firstNumber} and {secondNumber} is {sum}");     // Prints the output

        }
        public void subtract()
        {
            Console.WriteLine("Enter your first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int secondNumber = int.Parse(Console.ReadLine());
            ArithmeticOperationDelegate arithmeticOperationDelegate = new ArithmeticOperationDelegate(operations.subtract);
            int subtraction = arithmeticOperationDelegate(firstNumber, secondNumber);

            Console.WriteLine($"Subtraction of {firstNumber} and {secondNumber} is {subtraction}");

        }
        public void multiply()
        {
            Console.WriteLine("Enter your first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int secondNumber = int.Parse(Console.ReadLine());
            ArithmeticOperationDelegate arithmeticOperationDelegate = new ArithmeticOperationDelegate(operations.multiply);
            int multiplication = arithmeticOperationDelegate(firstNumber, secondNumber);

            Console.WriteLine($"Multiplication of {firstNumber} and {secondNumber} is {multiplication}");

        }

        public void divide()
        {
            Console.WriteLine("Enter your first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int secondNumber = int.Parse(Console.ReadLine());
            ArithmeticOperationDelegate arithmeticOperationDelegate = new ArithmeticOperationDelegate(operations.divide);
            int division = arithmeticOperationDelegate(firstNumber, secondNumber);

            Console.WriteLine($"Division of {firstNumber} and {secondNumber} is {division}");

        }
    }
}
