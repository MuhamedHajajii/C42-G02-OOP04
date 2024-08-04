using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP04.Interfaces
{
    internal interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }
          void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Rectangle, Width: {Width}, Height: {Height}, Area: {Area}");
        }
    }
}
