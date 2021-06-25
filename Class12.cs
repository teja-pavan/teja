using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projct
{
    class Class12
    {
        class GFG
        {

            // adding two integer values.
            public int Add(int a, int b)
            {
                int sum = a + b;
                return sum;
            }

            // adding three integer values.
            public int Add(int a, int b, int c)
            {
                int sum = a + b + c;
                return sum;
            }

            // Main Method
            public static void Main(String[] args)
            {

                // Creating Object
                GFG ob = new GFG();

                int sum1 = ob.Add(1, 2);
                Console.WriteLine("sum of the two "
                                  + "integer value : " + sum1);

                int sum2 = ob.Add(1, 2, 3);
                Console.WriteLine("sum of the three "
                                  + "integer value : " + sum2);
            }
        }
    }
namespace Overload_methods_and_invoke
    {
        public class Area
        {
            public double area(double s)
            {
                double area = s * s;
                return area;
            }

            public double area(double l, double b)
            {
                double area = l * b;
                return area;
            }
        }
    }
    namespace MyApplication
    {
        class Program
        {
            static int PlusMethodInt(int x, int y)
            {
                return x + y;
            }

            static double PlusMethodDouble(double x, double y)
            {
                return x + y;
            }

            static void Main(string[] args)
            {
                int myNum1 = PlusMethodInt(8, 5);
                double myNum2 = PlusMethodDouble(4.3, 6.26);
                Console.WriteLine("Int: " + myNum1);
                Console.WriteLine("Double: " + myNum2);
            }
        }
    }
}
