using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareQualityA2
{
    public class Rectangle
    {
        private int rectLength;
        private int rectWidth;

        public Rectangle()
        {
            rectLength = 1;
            rectWidth = 1;
        }

        public Rectangle(int length, int width)
        {
         this.rectLength = length;
         this.rectWidth = width;
        }

        public int GetLength()
        {
            return rectLength;
        }

        public int SetLength(int length)
        {
          this.rectLength = length;
          return this.rectLength;
        }

        public int GetWidth()
        {
            return rectWidth;
        }

        public int SetWidth(int width)
        {
          this.rectWidth = width;
          return this.rectWidth;
        }

        public int GetPerimeter()
        {
            int perimeter = 2 * (rectWidth + rectLength);
            return perimeter;
        }

        public int GetArea()
        {
            int area = rectWidth * rectLength;
            return area;
        }

    }
}
