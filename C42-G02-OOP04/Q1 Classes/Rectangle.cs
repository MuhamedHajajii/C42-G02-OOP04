using C42_G02_OOP04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP04.Q1_Classes
{
    internal class Rectangle : IRectangle
    {
        public double Width { get;  set; }
        public double Height { get;  set; }
        public double Area => Width * Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }


    }
}
