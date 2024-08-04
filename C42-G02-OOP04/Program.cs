using C42_G02_OOP04.Interfaces;
using C42_G02_OOP04.Q1_Classes;
using C42_G02_OOP04.Q2;
using C42_G02_OOP04.Q2_Interfaces;
using C42_G02_OOP04.Q3;

namespace C42_G02_OOP04
{
    internal class Program
    {


        static void Main()
        {

            #region Part 01

            /// Question 1:  What is the primary purpose of an interface in C#?
            ///b) To define a blueprint for a class

            /// Question 2:  Which of the following is NOT a valid access modifier for interface members in C#?
            ///a) private
            ///b) protected

            /// Question 3:  Can an interface contain fields in C#?
            ///b) No

            /// Question 4:  In C#, can an interface inherit from another interface?
            ///b) Yes, interfaces can inherit from multiple interfaces

            /// Question 5:  Which keyword is used to implement an interface in a class in C#?
            ///d) implements

            /// Question 6:  Can an interface contain static methods in C#?
            ///a) Yes

            /// Question 7:  In C#, can an interface have explicit access modifiers for its members?
            ///b) No, all members are implicitly public

            /// Question 8:  What is the purpose of an explicit interface implementation in C#?
            ///a) To hide the interface members from outside access

            /// Question 9:  In C#, can an interface have a constructor?
            ///b) No, interfaces cannot have constructors

            /// Question 10:  How can a C# class implement multiple interfaces?
            ///c) By separating interface names with commas


            #endregion

            #region Part 02

            #region Q1
            /**
             * Define an interface named IShape with a property Area and a method DisplayShapeInfo.
             * Create two interfaces, ICircle and IRectangle, that inherit from IShape.
             * Implement these interfaces in classes Circle and Rectangle.
             * Test your implementation by creating instances of both classes and displaying their shape information.
             */

            //// Create an instance of Circle
            //ICircle circle = new Circle(5);
            //circle.DisplayShapeInfo();

            //// Create an instance of Rectangle
            //IRectangle rectangle = new Rectangle(4, 6);
            //rectangle.DisplayShapeInfo();
            #endregion

            #region Q2

            //// Create an instance of BasicAuthenticationService
            //IAuthenticationService authService = new BasicAuthenticationService();

            //// Authenticate users
            //bool isAuthenticated = authService.AuthenticateUser("user1", "password1");
            //Console.WriteLine($"User1 authenticated: {isAuthenticated}");

            //isAuthenticated = authService.AuthenticateUser("user2", "wrongpassword");
            //Console.WriteLine($"User2 authenticated: {isAuthenticated}");

            //// Authorize users
            //bool isAuthorized = authService.AuthorizeUser("user1", "admin");
            //Console.WriteLine($"User1 authorized as admin: {isAuthorized}");

            //isAuthorized = authService.AuthorizeUser("user2", "admin");
            //Console.WriteLine($"User2 authorized as admin: {isAuthorized}");

            #endregion

            #region Q3
            //// Create instances of each notification service
            //INotificationService emailService =  new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //// Send notifications using each service
            //emailService.SendNotification("email@example.com", "This is an email notification.");
            //smsService.SendNotification("123-456-7890", "This is an SMS notification.");
            //pushService.SendNotification("user123", "This is a push notification.");
            #endregion

            #endregion

        }
    }
}
