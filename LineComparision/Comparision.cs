using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    public class Comparision
    {
        int x1,x2, y1, y2;
        public Comparision(int _x1, int _x2, int _y1, int _y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public void CalculateLength()
        {
            double LineLength = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2));
            Console.WriteLine(LineLength);
        }
    }
}
