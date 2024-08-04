using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    // this class now can must the implementation of the interface

    // Class     : Class -> inherit
    // Class     : Interface -> implement
    // Struct    : Interface -> implement
    // Interface : Interface -> inherit
    internal class MyType : IMyType
    {
        // Compiler will generate private hidden attribute [backing field]
        // i can add more signature for the properties and the methods but but must implement it first 
        public int Id { get; set; }
        public string Name { get; set; }

        public void MyFun(int x)
        {
            Console.WriteLine($"Hello Route : X = {x} , Id = {Id} , Name = {Name}");
        }
    }
}
