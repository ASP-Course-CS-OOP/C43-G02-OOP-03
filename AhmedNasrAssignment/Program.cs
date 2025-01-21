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

        }
    }
}
