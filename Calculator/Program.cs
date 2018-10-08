using System;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Program
    {
        // private readonly int[] integers = new int[3];

        static void Main(string[] args)
        {
            // ask user for 2 num operation using +, *, -, /.
            string userInput = AskForUserInput();

            // check if there are more than two operands and one operation
            string[] integers = Regex.Replace(userInput, @"\s", "").Split(new char[] { '+', '*', '-', '/' });
            int[] parsedNums = new int[2];

            // expression array must have only 2 indeces and both must be ints.
            if (integers.Length == 2)
            {
                for (int i = 0; i < integers.Length; i++)
                {
                    int parsed;
                    int.TryParse(integers[i], out parsed);
                    parsedNums[i] = parsed;
                }
            } else
            {
                AskForUserInput();
            }

           // use contains to pass along the ints to the operations
            int x = parsedNums[0];
            int y = parsedNums[1];

            if (userInput.Contains("+"))
            {
                Add(x, y);
            } else if (userInput.Contains("*"))
            {
                Multiply(x, y);
            } else if (userInput.Contains("/"))
            {
                Divide(x, y);
            } else if (userInput.Contains("-"))
            {
                Subtract(x, y);
            }

            Console.ReadLine();
        }

        static string AskForUserInput()
        {
            Console.WriteLine("Welcome to my calculator! Try a 2 number operation using +, -, /, *");
            return Console.ReadLine();
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
            } finally
            {
                Console.WriteLine("We get here");
                Console.ReadLine();
            }

            return x / y;
        }
    }
}

