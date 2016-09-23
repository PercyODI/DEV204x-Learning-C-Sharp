using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Decision Statements

            //int condition1, condition2, switchCondition;

            //condition1 = 1;
            //if (condition1 == 1)
            //{
            //    Console.WriteLine("Comparison evaluated to true");
            //}

            //Console.WriteLine("This executes after the if, regardless of what has taken place");

            //// if-else
            //condition1 = 3;
            //if (condition1 == 1)
            //{
            //    Console.WriteLine("Comparison evalued to true");
            //}
            //else
            //{
            //    Console.WriteLine("Comparison evaluated to false");
            //}

            //// if-else-if
            //condition1 = 1;
            //condition2 = 2;
            //if (condition1 == 1)
            //{
            //    Console.WriteLine("Condition1 to true");
            //}
            //else if (condition2 == 2)
            //{
            //    Console.WriteLine("Condition2 is true");
            //}
            //else
            //{
            //    Console.WriteLine("Neither Condition is true");
            //}


            //// Switch
            //switchCondition = 5;

            //switch (switchCondition)
            //{
            //    case 1:
            //        Console.WriteLine("Value is 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Value is 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("Value is 3");
            //        break;
            //    default:
            //        Console.WriteLine("Value is " + switchCondition);
            //        break;
            //}
            #endregion

            #region Repetition Statements
            int whileCounter = 0;
            int doCounter = 15;

            Console.WriteLine("for loop");
            Console.WriteLine();

            for (int forCounter = 0; forCounter < 10; forCounter++)
            {
                Console.WriteLine("forCounter is at " + forCounter);
            }

            Console.WriteLine();
            Console.WriteLine("while loop");
            Console.WriteLine();

            while (whileCounter < 5)
            {
                Console.WriteLine("whileCounter is at " + whileCounter);
                whileCounter++;
            }

            Console.WriteLine();
            Console.WriteLine("do-while loop");
            Console.WriteLine();

            do
            {
                Console.WriteLine("doCounter is at " + doCounter);
                doCounter++;
            } while (doCounter < 5);



            // Recersion Sample
            Console.WriteLine();
            Console.WriteLine("Recursion");
            Console.WriteLine();

            long value = Factorial(10);
            Console.WriteLine(value);

            

            Console.ReadLine();
            #endregion
        }
        static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}
