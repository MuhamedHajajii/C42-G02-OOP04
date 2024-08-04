using C42_G02_OOP04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP04.Q1_Classes
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }


    }
}
