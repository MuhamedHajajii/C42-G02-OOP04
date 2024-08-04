using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP04.Interfaces
{
    internal interface ICircle : IShape
    {
        double Radius { get; }
          void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Circle, Radius: {Radius}, Area: {Area}");
        }
    }
}
