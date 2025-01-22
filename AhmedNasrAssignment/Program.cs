using System.Runtime.CompilerServices;

namespace AhmedNasrAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01

            #region Q01 - Write a class named Calculator that contains a method named Add. Overload the Add method to:

            //int Add2Int = Calculator.Add(1, 2);
            //Console.WriteLine(Add2Int);// 3

            //int Add3Int = Calculator.Add(1, 2,5);
            //Console.WriteLine(Add3Int);// 8


            //double Add2Double = Calculator.Add(1.7, 2.9);
            //Console.WriteLine(Add2Double);// 4.6

            #endregion

            #region Q02 - Create a class named Rectangle with the following constructors:

            //Rectangle rectangle01 = new Rectangle();
            //Console.WriteLine(rectangle01.Width);//0
            //Console.WriteLine(rectangle01.Height);//0

            //Rectangle rectangle02 = new Rectangle(5,6);
            //Console.WriteLine(rectangle02.Width);//5
            //Console.WriteLine(rectangle02.Height);//6

            //Rectangle rectangle03 = new Rectangle(4);
            //Console.WriteLine(rectangle03.Width);//4
            //Console.WriteLine(rectangle03.Height);//4

            #endregion

            #region Q03 - Define a class Complex Number that represents a complex number with real and imaginary parts. Overload the +, - operator to add and subtract two complex numbers.

            //Complex c1 = new Complex(1, 2);
            //Complex c2 = new Complex(4, 5);
            //Complex c3 = c1 + c2;
            //Complex c4 = c1 - c2;

            #region c1+c2

            //Console.WriteLine($"c1: {c1}");
            //Console.WriteLine($"c2: {c2}");
            //Console.WriteLine("-----------");
            //Console.WriteLine($"c3: {c3}");

            #endregion

            #region c1-c2

            //Console.WriteLine($"c1: {c1}");
            //Console.WriteLine($"c2: {c2}");
            //Console.WriteLine("-----------");
            //Console.WriteLine($"c4: {c4}");

            #endregion

            #endregion

            #region Q04 - Create a base class named Employee with method Work those prints "Employee is working".Create a derived class named Manager that overrides the Work method to print "Manager is managing". Ensure that the Manager class also calls the Work method of the Employee class within its overridden method.

            //Manager manager = new Manager();
            //manager.Work();

            #endregion

            #region Q05 - Create a base class BaseClass with a virtual method DisplayMessage that prints "Message from BaseClass".

            //BaseClass baseClass = new DerivedClass1();
            //baseClass.DisplayMessage();// Message from DerivedClass1 - [Bind the function call to the last override of DisplayMessage() in range of overriding chain from Class "BaseClass" to "class DerivedClass1" using CLR in run time] [Dynamic Binding ]

            //baseClass = new DerivedClass2();
            //baseClass.DisplayMessage();// Message from BaseClass - [Bind the function call to the function of the reference class type - which is the function of "BaseClass" using compiler in compile time]



            #endregion

            #endregion

            #region Part02

            #region Q1 - Q3

            //Duration d1 = new Duration(1, 10, 15);
            //Console.WriteLine(d1);// Hours: 1, Minuites: 10, Seconds: 15

            //Duration d2 = new Duration(3600);
            //Console.WriteLine(d2);// Hours: 1, Minuites: 0, Seconds: 0

            //Duration d3 = new Duration(7800);
            //Console.WriteLine(d3);// Hours: 2, Minuites: 10, Seconds: 0

            //Duration d4 = new Duration(666);
            //Console.WriteLine(d4);// Minuites: 11, Seconds: 6 

            #endregion

            #region Q4

            #region D3=D1+D2

            //Duration d1 = new Duration(3600);
            //Duration d2 = new Duration(4700);
            //Duration d3 = d1 + d2;

            //Console.WriteLine($"d1: {d1}");// d1: Hours: 1, Minuites: 0, Seconds: 0
            //Console.WriteLine($"d2: {d2}");// d2: Hours: 1, Minuites: 18, Seconds: 20
            //Console.WriteLine($"d3: {d3}");// d3: Hours: 2, Minuites: 18, Seconds: 20

            #endregion

            #region D3=D1 + 7800

            //Duration d1 = new Duration(3600);
            //int d2 = 7800;
            //Duration d3 = d1 + d2;

            //Console.WriteLine($"d1: {d1}");// d1: Hours: 1, Minuites: 0, Seconds: 0
            //Console.WriteLine($"d2: {d2}");// d2: 7800
            //Console.WriteLine($"d3: {d3}");// d3: Hours: 3, Minuites: 10, Seconds: 0

            #endregion

            #region D3=666+D3

            //int d1 = 666;
            //Duration d2 = new Duration(3600);
            //Duration d3 = d1 + d2;

            //Console.WriteLine($"d1: {d1}");// d1: 666
            //Console.WriteLine($"d2: {d2}");// d2: Hours: 1, Minuites: 0, Seconds: 0
            //Console.WriteLine($"d3: {d3}");// d3: Hours: 1, Minuites: 11, Seconds: 6

            #endregion

            #region D3= ++D1 (Increase One Minute)

            //Duration d1 = new Duration(4700);
            //Duration d2 = new Duration(3600);

            //Console.WriteLine($"d1: {d1}");// d1: Hours: 1, Minuites: 18, Seconds: 20

            //Duration d3 = ++d1;

            //Console.WriteLine($"d3: {d3}");// d3: Hours: 1, Minuites: 19, Seconds: 20

            #endregion

            #region D3 = --D2 (Decrease One Minute)

            //Duration d2 = new Duration(4750);

            //Console.WriteLine($"d2: {d2}");// d1: Hours: 1, Minuites: 19, Seconds: 20

            //Duration d3 = --d2;

            //Console.WriteLine($"d3: {d3}");// d3: Hours: 1, Minuites: 18, Seconds: 20

            #endregion

            #region D1= D1 -D2

            //Duration d1 = new Duration(3600);
            //Duration d2 = new Duration(4700);
            //Console.WriteLine($"d1: {d1}");
            //Console.WriteLine($"d2: {d2}");
            //d1 = d1 - d2;
            //Console.WriteLine($"d1: {d1}");


            #endregion

            #region If (D1>D2)

            //Duration d1 = new Duration(4700);
            //Duration d2 = new Duration(3600);

            //Console.WriteLine($"d1: {d1}");
            //Console.WriteLine($"d2: {d2}");
            //if (d1 > d2)
            //{
            //    Console.WriteLine("d1 is greater than d2!");
            //}
            //else if (d1 < d2)
            //{
            //    Console.WriteLine("d1 is less than d2!");
            //}
            //else
            //{
            //    Console.WriteLine("d1 equals d2");
            //}

            #endregion

            #region If (D1<=D2)

            //Duration d1 = new Duration(2600);
            //Duration d2 = new Duration(3600);

            //Console.WriteLine($"d1: {d1}");
            //Console.WriteLine($"d2: {d2}");
            //if (d1 <= d2)
            //{
            //    Console.WriteLine("d1 is less than or equal d2!");
            //}
            //else
            //{
            //    Console.WriteLine("d1 is Greater than or equal d2!");

            //}

            #endregion

            #region If (D1)

            //Duration d1 = new Duration(2600);

            //if ((bool)d1)
            //{
            //    Console.WriteLine("d1 is non zero!");
            //}


            #endregion

            #region DateTime Obj = (DateTime) D1

            //Duration d1 = new Duration(2750);

            //DateTime Obj = (DateTime)d1;

            //Console.WriteLine(Obj.ToString("HH:mm:ss"));

            #endregion


            #endregion


            #endregion

        }
    }
}
