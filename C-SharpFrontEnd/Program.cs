using System;

using System.Runtime.InteropServices;

namespace C_SharpFrontEnd
{
    class Program
    {
        //add the dll file to the C# front end build folder
        [DllImport("WIN_32_CPP_DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int IncrementNumber(int a);
        [DllImport("WIN_32_CPP_DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Fibonacci(int max);

        static void Main(string[] args)
        {
            //calling cpp code from CLR_CPP
            Console.WriteLine(CLR_CPP.CLR_CPP_CLASS.Multiply(75, 43));

            //calling cpp code from WIN_32_CPP_DLL
            Console.WriteLine(IncrementNumber(45));    

            //calling a more complex function
            Console.WriteLine(Fibonacci(4));

            Console.ReadLine();
        }
    }
}
