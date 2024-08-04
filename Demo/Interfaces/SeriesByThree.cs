using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    internal class SeriesByThree : ISeriees
    {
        public int Current { get; set; }

        public void GetNext() => Current += 3;
        

        //public void Rest() => Current = 0;
    }
}
