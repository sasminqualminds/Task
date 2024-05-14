using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    internal class Number
    {
        // declared two public fields and stored the values in it
        public int firstNumber=100;
        public int secondNumber=200;

        // created a virual method - allowing it to be overridden in derived classes
        public virtual void operation()
        {
            Console.WriteLine("Performing the operations");
        }
    }
}
