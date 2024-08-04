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

            #region 5- Deep Copy And Shallow Copy

            #endregion

        }
    }
}
