using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    internal class Car : Vehicle, IMoveable
    {
        // Speed
        // moveforward();
        // movebackward();
        // right();
        // left();
        public void Backward()
        {
            Console.WriteLine("Car MoveBackward on Ground");
        }

        public void Forward()
        {
            throw new NotImplementedException();
        }

        public void Left()
        {
            
        }

        public void Right()
        {
           
        }
    }
}
