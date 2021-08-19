using System;

 

namespace Tutlane

{

    class Program

    {

        static void Main(string[] args)

        {

            int x = 10;

            Console.WriteLine("Variable Value Before Calling the Method: {0}", x);

            Multiplication(ref x);

            Console.WriteLine("Variable Value After Calling the Method: {0}", x);

            Console.WriteLine("Press Enter Key to Exit..");

            Console.ReadLine();

        }

        public static void Multiplication(ref int a)

        {

            a *= a;

            Console.WriteLine("Variable Value Inside the Method: {0}", a);

        }

    }

}