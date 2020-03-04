using System;
using System.Collections.Generic;
using System.IO;

namespace GenericSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 4;
            int second = 5;
            Console.WriteLine("First: "+first.ToString());
            Console.WriteLine("Second: "+second.ToString());
            Swap<int>(ref first, ref second);
            Console.WriteLine("First: "+first.ToString());
            Console.WriteLine("Second: "+second.ToString());
        }

        static void Swap<T>(ref T input1, ref T input2)
        {
            T temp = default(T);

            temp = input2;
            input2 = input1;
            input1 = temp;
        }
    }
}
