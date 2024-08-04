using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    internal interface ISeriees
    {
        // So Now if you want to implemenmt the series must includes these signatures
        public int Current { get; set; }

        public void GetNext();

        public void Rest() => Current = 0;

        // if i have a signagure for a method and the same functions will have the same fucntionality every time i implment it make it defualt implemented method

    }
}
