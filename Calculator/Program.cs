using System;

namespace Calculator
{
    class Program
    {
        // public string[] Expression = new string[3];

        static void Main(string[] args)
        {
            // check if there are more than two operands and one operation
            string[] integers = args[0].Replace(" ", "").Split(new char[] { '+', '*', '-', '/' });
            // expression array must have only 2 indeces and both must be ints.
            if (integers.Length == 2)
            {
                for (int i = 0; i < integers.Length; i++)
                {
                    try
                    {
                        int parsed = int.Parse(integers[i]);
                        // try handling error in try block instead of using catch
                    } catch
                    {

                    }
                }
           // use contains to pass along the ints to the operations

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

