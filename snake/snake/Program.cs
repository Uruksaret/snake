using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Point p1 = new Point(1, 2, '*');
            p1.Draw();
            

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            //Отрисовка Рамки
            VerticalLine leftLine = new VerticalLine(0, 24, 0,'+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');

            leftLine.Draw();
            rightLine.Draw();
            upLine.Draw();
            downLine.Draw();
                    
            Console.ReadLine();
        }        
    }
}
