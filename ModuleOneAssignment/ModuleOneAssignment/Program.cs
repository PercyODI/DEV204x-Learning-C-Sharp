using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleOneAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Name: ");
            String firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            String lastName = Console.ReadLine();

            Console.Write("Birthdate: ");
            DateTime birthdate = Convert.ToDateTime(Console.ReadLine());
            String addressLine1;
            String addressLine2;
            String city;
            String state;
            int zip;
            String country;

            Console.WriteLine(firstName + " " + lastName + " " + birthdate);
            Console.ReadLine();


        }
    }
}
