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
            
            //Отрисовка Рамки
            VerticalLine leftLine = new VerticalLine(0, 24, 0,'+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');

            leftLine.Draw();
            rightLine.Draw();
            upLine.Draw();
            downLine.Draw();

            Point p = new Point(3, 4, '*');

            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Draw();

            Console.ReadLine();
        }        
    }
}
