using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    internal class AirPlane : Vehicle, IMoveable, IFlyAble
    {
        // Implement for two interfaces and inherit from the vehicle
        // Speed
        // moveforward();
        // movebackward();
        // right();
        // left();

        // moveforward();
        // movebackward();
        // right();
        // left();
        // Implement Explicityly

        //public void Backward()
        //{

        //}

        //public void Forward()
        //{

        //}

        //public void Left()
        //{

        //}

        //public void Right()
        //{

        //}
        void IMoveable.Backward()
        {
            Console.WriteLine("AirPlane MoveBackward");
        }

        void IFlyAble.Backward()
        {
            Console.WriteLine("AirPlane MoveBackward");
        }

        void IMoveable.Forward()
        {
            throw new NotImplementedException();
        }

        void IFlyAble.Forward()
        {
            throw new NotImplementedException();
        }

        void IMoveable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyAble.Left()
        {
            throw new NotImplementedException();
        }

        void IMoveable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyAble.Right()
        {
            throw new NotImplementedException();
        }
    }
}
