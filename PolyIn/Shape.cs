using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyIn
{
    class Shape
    {
        private int width;
        private int height;
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
    }
    // DERIVED CLASS
    class Rectangle : Shape {
        public int getArea(int width, int height)
        {
            return (width * height);
        }
    }

    sealed class Triangle : Shape
    {
        public int getArea(int width, int height)
        {
            return ((width * height) / 2);
        }
    }
}

