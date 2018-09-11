using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adder
{
    public class InitialConditions
    {
        // set the initial values of the sum total, the count and the quantity of numbers to be added
        public static void GetStartConditions(out int sum, out int count, out int quantity)
        {
            sum = 0;
            count = 0;
            quantity = QtyMethod(); // call this method to get the user input for the quantity
        }

        public static int QtyMethod()
        {
            int quantity;
            Console.WriteLine("How many numbers do you want to add together? Enter a number from 2 to 5 inclusive:");
            try
            {
                // convert the input string to a Int32, and throw a Exception error if it is a number but not in range 2 to 5
                quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity < 2 || quantity > 5)
                {
                    throw new Exception();
                }
            }
            // if the user input is not a numerical value, catch it and call this method again to get the quantity
            catch (FormatException)
            {
                Console.WriteLine("Whoops! You didn't enter a number.");
                quantity = QtyMethod();
            }
            // if the user input is a numerical value but not in range 2 to 5, catch it and call this method again to get the quantity
            catch (Exception)
            {
                Console.WriteLine("Whoops! You didn't enter a number in the range 2 to 5 inclusive.");
                quantity = QtyMethod();
            }

            return quantity;
        }
    }
}
