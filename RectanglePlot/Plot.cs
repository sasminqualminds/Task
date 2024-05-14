using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePlot
{
    // inherited the fields and methods of Rectangle plot
    internal class Plot:Rectangle
    {
        // field
        public double cost;

        // method
        public double costOfRectanglePlot()
        {
            return areaOfRectangle()*cost;           
        }
    }
}
