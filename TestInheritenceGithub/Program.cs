using System;

namespace TestInheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            BC b;
            b = new BC();
            b.Display();

            b = new DC();
            b.Display();

            b = new TC();
            b.Display();

            TC c;
            c = new TC();
            c.Display();

            Console.ReadLine();
        }
    }
    class BC  // Base Class
    {
        public virtual void Display()
        {
            System.Console.WriteLine("BC::Display");
        }
    }

    class DC : BC   // Derived Class
    {
        public override void Display()
        {
            System.Console.WriteLine("DC::Display");
        }
    }
    class TC : BC
    {
        new public void Display()
        {
            System.Console.WriteLine("TC::Display");
        }
    }
}