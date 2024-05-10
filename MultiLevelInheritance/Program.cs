
// Write a  Program to Demonstrate Multilevel Inheritance with Virtual Methods

namespace MultiLevelInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // created an instance of AdditionOfThreeNumbers class
            AdditionOfThreeNumbers additionOfThreeNumbers = new AdditionOfThreeNumbers();
            // accessing the methods through object 
            additionOfThreeNumbers.operation();
            additionOfThreeNumbers.addingTwoNumbers();
            additionOfThreeNumbers.addingThreeNumbers();

        }
    }
}
