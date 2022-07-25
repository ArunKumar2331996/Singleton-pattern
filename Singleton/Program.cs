using System;

namespace Singleton
{
    // This sealed class will prevent inheritance.
    sealed class Program
    {
        //  This private prooperty helps us to create only one object during run time.
        private static object Instance = null;
        private Program()
        {
            // This private constructor will not allow us to create new object.
        }

        static Program()
        {
            // This static constructor helps us to create new object only one time
            // when application starts running.

            if (Instance == null) 
                Instance = new Program();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }       
    }
}
