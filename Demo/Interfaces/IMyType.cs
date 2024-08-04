using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    // Code contruct that other classes must follow
    // defult access modifier for the interface is internal
    internal interface IMyType
    {
        /** What I Can Type Inside The Interface
         * 1- Signature for property
         * 2- signature for method
         * 3- defult implemented methods
         * 
         * access modifier allowed in the interface is public
         */

        // signature for property [in class or struct its called automatic property - a comipler will generete private hidden attruibute - baking field]
        // its only the signature only not the implementation
        public int Id { get; set; }

        // signature for method 
        // prototype -- return type , name , parameters
        // its only the implementation i don't know what the implementation of the function
        public void  MyFun(int x);

        // defult implemented method c# 8.0 feature .Net Core 2019
        // the full prototype for the function
        // who will apply the interface don't need to make the implementation its already implemented
        public void Print()
        {
            Console.WriteLine("Hello Defult Implemented Method From The Interface");
        }

    }
}
