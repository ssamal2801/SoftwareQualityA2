using System;

namespace SoftwareQualityA2
{
    public class Rectangle
    {

        private int rectLength, rectWidth;

        public Rectangle()
        {
            rectLength = 5;
            rectWidth = 5;
        }

        public Rectangle(int length, int width)
        {
            if (length < 1)
            {
                throw new ArithmeticException();
            }
            if (width < 1)
            {
                throw new ArithmeticException();
            }

            this.rectLength = length;
         this.rectWidth = width;
        }

        public int GetLength()
        {
            return rectLength;
        }

        public int SetLength(int length)
        {
            if(length>0)
            {
                this.rectLength = length;
            }
            return this.rectLength;
        }

        public int GetWidth()
        {
            return rectWidth;
        }

        public int SetWidth(int width)
        {
            if (width > 0)
            {
               this.rectWidth = width;
            }
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
