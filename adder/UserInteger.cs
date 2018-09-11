using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adder
{
    public class UserInteger
    {
        public int GetUserInput()
        {
            userValue = GetValue(); // call this method to get the numerical value from the user
            return userValue;
        }

        public int GetValue()
        {
            int value;
            Console.WriteLine("Enter an integer:");
            try
            {
                // convert the unput string to an Int32
                value = Convert.ToInt32(Console.ReadLine());
            }
            // if the user input is not a numerical value, catch it and call this method again to get a numerical value
            catch (FormatException)
            {
                Console.WriteLine("Silly you! You didn't enter a number.");
                value = GetValue();
            }

            return value;
        }

        public int userValue;
        
    }
}
