using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwoAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean again = false;
            do
            {
                Console.Write("Enter Number of Rows: ");
                int numRows = Convert.ToUInt16(Console.ReadLine());

                Console.Write("Enter Number of Columns: ");
                int numCols = Convert.ToUInt16(Console.ReadLine());

                Console.Write("\n");

                for (int rowCounter = 0; rowCounter < numRows; rowCounter++)
                {
                    if (rowCounter % 2 == 0)
                    {
                        for (int colCounter = 0; colCounter < numCols; colCounter++)
                        {
                            if (colCounter % 2 == 0)
                            {
                                Console.Write("X");
                            }
                            else
                            {
                                Console.Write("O");
                            }
                        }
                        Console.Write("\n");
                    }
                    else
                    {
                        for (int colCounter = 0; colCounter < numCols; colCounter++)
                        {
                            if (colCounter % 2 == 0)
                            {
                                Console.Write("O");
                            }
                            else
                            {
                                Console.Write("X");
                            }
                        }
                        Console.Write("\n");
                    }
                }

                Console.Write("Would you like to make another (y or n)? ");
                String userResponse = Console.ReadLine();
                if (userResponse == "y" || userResponse == "Y")
                {
                    again = true;
                }
                else
                {
                    again = false;
                }
            } while (again == true);
        }
    }
}
