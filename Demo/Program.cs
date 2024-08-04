﻿using Demo.Interfaces;
using System.Text;

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

            //// Create User Defind datatype from the interface

            //// Cannot Create Object from the interface because its only includes the signature not the implementation for the code
            //// can only craete reference from the interface
            //// allocate 4 bytes for the reference 
            //// refer to null
            ////IMyType myType = new IMyType(); // Invalid
            //IMyType myType;
            ////can refer for struct or enum which implement this interface
            ////myType.Id = 1; // invalid because its only inculdes the signature and refer to null
            //// in general the interface cannot create object its only a code contract that other classes or struct must follow
            //// you can create reference from it but can only refer for struct or classes which implemented that interface

            //MyType myType01 = new MyType();
            //myType01.Id = 30;
            //myType01.MyFun(100); // invalid
            //// because the defult implemented methods can only access by the reference of the interface which will refer for object which will implement this interface

            //// this object built with the defult paramater less constructor
            //myType = new MyType();
            //myType.Id = 30;
            //myType.MyFun(100);
            //myType.Print();
            //myType.Name // invalid because the reference only refer to his part inside the object only

            // Code Contarct that classes or struct must follow 

            #endregion

            #region 2- Interface Example01

            ////    code contract the following classes and structs must follow and implement those signatures
            ////    Create Series Implementation -->

            ////   SeriesByTwo seriesByTwo = new SeriesByTwo();
            ////    Print10NumbersFromSeries(seriesByTwo);

            ////    Console.WriteLine("\n======================");

            ////    SeriesByThree seriesByThree = new SeriesByThree();
            ////    Print10NumbersFromSeries(seriesByThree);

            ////    Console.WriteLine("\n======================");

            ////    SerieaByFour serieaByFour = new SerieaByFour();
            ////    Print10NumbersFromSeries(serieaByFour); invalid because its not implement the interface even it already include the same methods and properties
            ////     because i made a contract with you if you want to declare a ref from this interface you must type all the signature inside it
            ////     puls sign the contract


            ////     now the parameter refer to object from datatype SerivesByTwo so i can implement behavior for it in the method
            ////     but if i want to change the behavior inside the datatype it will not implement it
            ////    void Print10NumbersFromSeries(SeriesByTwo serise)

            ////     now decaler a ref from the interface ISeries so i will be sure that any object will be sent to it will implemet the same behavior and same functions
            ////     implement the interface series fo sure so i can do same functionilaty 100% with differenct behavior every time

            ////     made the contract and sign the contract to make sure the other proccess will work
            ////     signatures make you make sure that the other proccess you will make will throw no exceptions
            ////     you can add more signature will implementing but can not decrease them

            ////    void Print10NumbersFromSeries(ISeriees serise)
            ////{
            ////    if (serise is not null)
            ////    {
            ////        for (int i = 0; i < 10; i++)
            ////        {
            ////            Console.Write(serise.Current + " "); //0 2 4 6 8 10 12 14 16 18
            ////            serise.GetNext();
            ////        }
            ////        serise.Rest();
            ////    }
            ////}


            #endregion

            #region 3- Interface [Explicitly and Implicitly]

            //// Interface has solve two main problem i was face
            //// the struct can't inherit from another struct --> Struct Can Implement Interface
            //// and the class can't inherit from more than one class  --> Class Can Implement More Than One Interface

            //Car car = new Car();
            //car.Backward();
            ////car.Forward();

            //AirPlane plane = new AirPlane();
            ////plane.Backward(); Invalid because i implement the functionality in the class but can't access it 

            //IFlyAble plane02 = new AirPlane();
            //plane02.Backward();

            // summary
            /** The Airplane has two differenct way to move on ground and onair
             * so i want to access both of them while i implement the interface 
             * so i must implement the interface explicitly and to access them 
             * i must create reference from the interface to referece for an object
             * so two cases to make a ref from the interface
             * explicitly implement for the interface
             * and default implemented methods
             */
            #endregion

            #region 4- Deep Copy And Shallow Copy for the value type

            /** Shallow Copy and Deep Copy 
             * Take a copy from something
             * it happen with the reference type
             * The Elments inside the array value type or reference type 
             */

            // Array of value type
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3]; // {0,0,0}

            //Console.WriteLine("===============================");
            //Console.WriteLine("Befor The Shallow Copy");
            //Console.WriteLine("===============================");

            //Console.WriteLine($"Arr01 = {Arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Arr02 = {Arr02.GetHashCode()}"); //18643596

            //Arr02 = Arr01; // Shallow Copy [Stack] surface copy both of them refer for the same object
            //Console.WriteLine("===============================");
            //Console.WriteLine("After The Shallow Copy");
            //Console.WriteLine("===============================");

            //Console.WriteLine($"Arr01 = {Arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Arr02 = {Arr02.GetHashCode()}"); //54267293            

            //Console.WriteLine("===============================");
            //Console.WriteLine("Before Change The Value of Arr01[0]");
            //Console.WriteLine("===============================");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            //Arr01[0] = 100;

            //Console.WriteLine("===============================");
            //Console.WriteLine("After Change The Value of Arr01[0]");
            //Console.WriteLine("===============================");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            /**
             *  Of You Made Any Change in any Array it will reflect on the other 
             *  because the both ref refer to the same object 
             *  and make an unreachable array in the heap
             *  It Happen only the stack with the references
             */

            // Deep Copy to get a copy from the heap not in the stack
            // You make a build in method called clone 

            //Array of value type
            int[] Arr01 = { 1, 2, 3 };
            int[] Arr02 = new int[3]; // {0,0,0}
                                      // Clone => DeepCoty
                                      // Deep Copy Occurred At Heap 
                                      // Create New object with different and new identity
                                      // that object will be the same object the same object state [Data] of the calles
                                      // return to an object 
                                      // its not know which object it will return so i must declare that i will return the object as the data type or the reciver

            //Console.WriteLine("===============================");
            //Console.WriteLine("Befor The Deep Copy");
            //Console.WriteLine("===============================");

            //Console.WriteLine($"Arr01 = {Arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Arr02 = {Arr02.GetHashCode()}"); //18643596

            //Arr02 = (int[])Arr01.Clone();
            //Console.WriteLine("===============================");
            //Console.WriteLine("After The Deep Copy");
            //Console.WriteLine("===============================");

            //Console.WriteLine($"Arr01 = {Arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Arr02 = {Arr02.GetHashCode()}"); //33574638

            //Console.WriteLine("===============================");
            //Console.WriteLine("Before Change The Value of Arr01[0]");
            //Console.WriteLine("===============================");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            //Arr01[0] = 100;

            //Console.WriteLine("===============================");
            //Console.WriteLine("After Change The Value of Arr01[0]");
            //Console.WriteLine("===============================");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            /** Summary:
             * Shallow Copy Works in the stack works in the Identity of the object works on the reference of the object [Address]
             * Deep Copy Workds in the Object State Workds on the data of the object workds on the heap
             */

            #endregion

            #region 5- Deeo Coy And Shallow Copy For The Rerference Type

            // Array of string [Immutable Type]

            //string[] Names01 = { "Omar" };
            //string[] Names02 = new string[1]; // {null}

            //Console.WriteLine("========================");
            //Console.WriteLine("Before");
            //Console.WriteLine("========================");

            //Console.WriteLine($"HS Code for Names01 = {Names01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HS Code for Names02 = {Names02.GetHashCode()}"); //18643596

            //Names02 = Names01; // Shallow Copy

            //Console.WriteLine("========================");
            //Console.WriteLine("After");
            //Console.WriteLine("========================");

            //Console.WriteLine($"HS Code for Names01 = {Names01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HS Code for Names02 = {Names02.GetHashCode()}"); //54267293

            //// Now The second will be unreachable object and the changes happen in the stack both of the refer to the same address now of the first array

            //Console.WriteLine("========================");
            //Console.WriteLine("Before Change Vlaues");
            //Console.WriteLine("========================");

            //Console.WriteLine($"HS Code for Names01 = {Names01[0]}"); // Omar
            //Console.WriteLine($"HS Code for Names02 = {Names02[0]}"); // Omar

            //Names01[0] = "Aya";

            //Console.WriteLine("========================");
            //Console.WriteLine("After Change Vlaues");
            //Console.WriteLine("========================");

            //Console.WriteLine($"HS Code for Names01 = {Names01[0]}"); // Aya
            //Console.WriteLine($"HS Code for Names02 = {Names02[0]}"); // Aya

            // shallow copy in the stack the both still refer to the same object [array of address] because its string immutable type and this will create new object for aya and the same address will hold it too

            //Console.WriteLine("========================");
            //Console.WriteLine("Before Deep Copy");
            //Console.WriteLine("========================");

            //Console.WriteLine($"HS Code for Names01 = {Names01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HS Code for Names02 = {Names02.GetHashCode()}"); //18643596

            //Names02 = (string[])Names01.Clone(); // Shallow Copy

            //// Create New Object with new differenct identity [new reference]
            //// this object will has the same object state [same data]

            //Console.WriteLine("========================");
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine("========================");

            //Console.WriteLine($"HS Code for Names01 = {Names01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HS Code for Names02 = {Names02.GetHashCode()}"); //54267293

            //// Now The second will be unreachable object and the changes happen in the stack both of the refer to the same address now of the first array

            //Console.WriteLine("========================");
            //Console.WriteLine("Before Change Vlaues");
            //Console.WriteLine("========================");

            //Console.WriteLine($"HS Code for Names01 = {Names01[0]}"); // Omar
            //Console.WriteLine($"HS Code for Names02 = {Names02[0]}"); // Omar

            //Names01[0] = "Aya";

            //Console.WriteLine("========================");
            //Console.WriteLine("After Change Vlaues");
            //Console.WriteLine("========================");

            //Console.WriteLine($"HS Code for Names01 = {Names01[0]}"); // Aya
            //Console.WriteLine($"HS Code for Names02 = {Names02[0]}"); // Aya

            // now the copy make a deep copy and create new object identity and new object state
            // but in the same time it make a shallow copy for the state 
            // and the array of reference will still hold the same reference 
            // but because its a string and string is a immutable type it will create new object or new state for the string when you chagne it 
            // but with the string builder it will change in the same ref so changes will appear 


            #endregion

            #region 6- Deep Copy And Shallow copy with reference type with the string builder not the string 

            /* String buidler is an mutable type and immutable type is a string */

            //StringBuilder[] Names01 = new StringBuilder[1];
            //Names01[0] = new StringBuilder("Omar");
            //StringBuilder[] Names02 = new StringBuilder[1];

            //Console.WriteLine("========================");
            //Console.WriteLine("Before Shallow Copy");
            //Console.WriteLine("========================");

            //Console.WriteLine($"HS Code Names01 = {Names01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HS Code Names02 = {Names02.GetHashCode()}"); //18643596

            //Names02 = Names01; // shallow copy both of them has same identity and refer to the same object

            //Console.WriteLine("========================");
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine("========================");

            //Console.WriteLine($"HS Code Names01 = {Names01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HS Code Names02 = {Names02.GetHashCode()}"); //54267293

            //Console.WriteLine("========================");
            //Console.WriteLine("Before Value");
            //Console.WriteLine("========================");

            //Console.WriteLine(Names01[0]);
            //Console.WriteLine(Names02[0]);

            //Names02[0].Append(" Amr");
            //Console.WriteLine("========================");
            //Console.WriteLine("After Value");
            //Console.WriteLine("========================");

            //Console.WriteLine(Names01[0]);
            //Console.WriteLine(Names02[0]);

            //StringBuilder[] Names01 = new StringBuilder[1];
            //Names01[0] = new StringBuilder("Omar");
            //StringBuilder[] Names02 = new StringBuilder[1];

            //Console.WriteLine("========================");
            //Console.WriteLine("Before Deep Copy");
            //Console.WriteLine("========================");

            //Console.WriteLine($"HS Code Names01 = {Names01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HS Code Names02 = {Names02.GetHashCode()}"); //18643596

            //Names02 = (StringBuilder[]) Names01.Clone(); // shallow copy both of them has same identity and refer to the same object

            //Console.WriteLine("========================");
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine("========================");

            //Console.WriteLine($"HS Code Names01 = {Names01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HS Code Names02 = {Names02.GetHashCode()}"); //54267293

            //Console.WriteLine("========================");
            //Console.WriteLine("Before Value");
            //Console.WriteLine("========================");

            //Console.WriteLine(Names01[0]);
            //Console.WriteLine(Names02[0]);

            //Names02[0].Append(" Amr");

            //Console.WriteLine("========================");
            //Console.WriteLine("After Value");
            //Console.WriteLine("========================");

            //Console.WriteLine(Names01[0]);
            //Console.WriteLine(Names02[0]);

            #endregion

        }
    }
}
