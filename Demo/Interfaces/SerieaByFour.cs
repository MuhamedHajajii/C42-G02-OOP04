using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    internal class SerieaByFour 
    {
        public int Current { get; set; }

        public void GetNext() => Current += 4;


        //public void Rest() => Current = 0;
    }
}
