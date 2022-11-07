using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Model
{
    public class Rectangle
    {
        public decimal StartPointX { get; private set; }

        public decimal StartPointY { get; private set; }

        public decimal EndPointX { get; private  set; }

        public decimal EndPointY { get; private set; }

        public decimal Width { get { return Math.Abs(EndPointX - StartPointX); } }

        public decimal Height { get { return Math.Abs(EndPointY - StartPointY); } }

        public Rectangle(decimal startPointX, decimal startPointY, decimal endPointX, decimal endPointY)
        {
            StartPointX = startPointX;
            StartPointY = startPointY;
            EndPointX = endPointX;
            EndPointY = endPointY;
        }
    }
}
