using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine:Figure
    {
        public VerticalLine(int yFirst, int ySecond, int x, char sum)
        {
            pList = new List<Point>();
            for (int y = yFirst; y <= ySecond; y++)
            {
                Point p = new Point(x, y, sum);
                pList.Add(p);
            }
        }        
    }
}
