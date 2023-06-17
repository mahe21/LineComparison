using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LenthofTheLineSegment
    {
        double x1;
        double y1;
        double x2;  
        double y2;
        double x3;
        double y3;
        double x4;
        double y4;

        public LenthofTheLineSegment(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            this.x1 = x1; this.y1 = y1; this.x2 = x2; this.y2 = y2;
            this.x3 = x3; this.x3 = y3; this.x4 = x4; this.y4 = y4;
        }
        public void lengthOfLine() 
        {
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"The length of the line segment is:" +length);
            double Length1 = ((Math.Sqrt(((x4 - x3) * (x4 - x3)) + ((y4 - y3) * (y4 - y3)))));
            Console.WriteLine("Length of Line:" + Length1);
            bool equalLength = length.Equals(Length1);
            if (equalLength == true)
            {
                Console.WriteLine("Both lines are equal");
            }
            else if (length > Length1)
            {
                Console.WriteLine("line1 is greater");
            }
            else
            {
                Console.WriteLine("Line2 is greater");
            }


        }

    }

}
