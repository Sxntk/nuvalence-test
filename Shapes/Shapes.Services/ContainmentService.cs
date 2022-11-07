using Shapes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Services
{
    public class ContainmentService
    {
        public bool IsContained(Rectangle rectangle1, Rectangle rectangle2)
        {
            if (rectangle1.StartPointX >= rectangle2.StartPointX)
            {
                return false;
            }

            if (rectangle1.EndPointX <= rectangle2.EndPointX)
            {
                return false;
            }

            if (rectangle1.StartPointY >= rectangle2.StartPointY)
            {
                return false;
            }

            if (rectangle1.EndPointY <= rectangle2.EndPointY)
            {
                return false;
            }

            return true;
        }
    }
}
