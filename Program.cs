﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Base class");
            Console.ReadLine();


            Display();

        }

        static void Display()
        {
            Console.WriteLine("my name is teja");
            Console.ReadLine();
        }

        static void line()
        {
            //singleline comment
            int value = 10;
            /*
             * a multiline comment
             */
            int v1 = value++;
            int v = v1;
#if false
                directive
#endif
            value *= 100;
            Console.WriteLine();
        }

        static void types()
        {
            int a = 4;
            float b = 7;
            double c = 2.34;
            char d = 'h';
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

        }

        static void variables()
        {
            int a;
            a = 100;
            // local variable
            Console.WriteLine("Value:" + a);
            Console.ReadLine();
        }

        static void printname()
        {
            Console.WriteLine("Teja");
            Console.ReadLine();

        }

        static void name()
        {
            // call directory static method eith class name
            Console.WriteLine();
        }
    }
}
        
    

