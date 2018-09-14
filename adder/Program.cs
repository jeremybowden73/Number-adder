using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // call static method to set up the initial conditions
            // (sum total, count, and quantity of numbers to add)
            InitialConditions.GetStartConditions(out int sum, out int count, out int quantity);

            // loop the required number of times (= quanity)
            // each time get an integer from the user and add it to the sum total
            while (count < quantity)
            {
                UserInteger usersInt = new UserInteger();

                // get a numerical value from the user using the GetUserInput method
                // and add it to the current sum total
                sum += usersInt.GetUserInput();
                count++;
            }

            Console.WriteLine($"The sum of all your numbers is {sum}.");
            Console.ReadLine();
        }
    }
}
