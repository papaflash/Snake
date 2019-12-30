using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //HorizontalLine horizontal = new HorizontalLine(5, 10, 8, '+');
            //VerticalLine vertical = new VerticalLine(5, 0, 10, '+');
            //vertical.Drow();
            //horizontal.Drow();
            Point p = new Point(1,3,'+');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            Console.ReadKey();
        }
    }
}
