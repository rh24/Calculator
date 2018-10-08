using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // check if there are more than two operands and one operation
            args[0].Replace(" ", "").Split(new char[] { '+', '*', '-', '/' });
        }

        static int Add(int x, int y)
        {
            Console.WriteLine((x + y).ToString());
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            Console.WriteLine(x - y);
            return x - y;
        }

        static int Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
            return x * y;
        }

        static int Divide(int x, int y)
        {
            try
            {
                Console.WriteLine(x / y);
                if (y == 0)
                {
                    throw new System.DivideByZeroException();
                }
            } catch (System.DivideByZeroException ex)
            {
                Console.WriteLine($"Cannot divide by {0}", ex);
            }

            return x / y;
        }
    }
}

