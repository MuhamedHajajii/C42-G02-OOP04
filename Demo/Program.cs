using Demo.Interfaces;

namespace Demo
{
    internal class Program
    {
        // Main Topics
        // 1- Interdace
        // 2- Deep copy and Shallow Copy
        // 4- ICloneable
        // 5- IComperable
        // 6- IComperar
        static void Main()
        {
            #region 1- Interface
            /** What Is The Inter Face -->>
             * Code Contract That Other Classes Must Follow -- defining behavior without implementation
             * -- The Available access modifers inside the inter face is public
             */

            // Create User Defind datatype from the interface

            // Cannot Create Object from the interface because its only includes the signature not the implementation for the code
            // can only craete reference from the interface
            // allocate 4 bytes for the reference 
            // refer to null
            //IMyType myType = new IMyType(); // Invalid
            IMyType myType;
            //can refer for struct or enum which implement this interface
            //myType.Id = 1; // invalid because its only inculdes the signature and refer to null
            // in general the interface cannot create object its only a code contract that other classes or struct must follow
            // you can create reference from it but can only refer for struct or classes which implemented that interface

            MyType myType01 = new MyType();
            myType01.Id = 30;
            myType01.MyFun(100); // invalid
            // because the defult implemented methods can only access by the reference of the interface which will refer for object which will implement this interface

            // this object built with the defult paramater less constructor
            myType = new MyType();
            myType.Id = 30;
            myType.MyFun(100);
            myType.Print();
                //myType.Name // invalid because the reference only refer to his part inside the object only

            // Code Contarct that classes or struct must follow 

            #endregion
        }
    }
}
