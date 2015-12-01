using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program for a piggy bank counter.Ask the user for 
            the number of pennies, nickels, dimes, quarters, half dollars, 
            and gold dollars.Print the total amount of money in the piggy bank. */

            Console.WriteLine("How many pennies do you have?");
            double pennies = Convert.ToDouble(Console.ReadLine());
            pennies = pennies * .01;

            Console.WriteLine("How many nickles do you have?");
            double nickles = Convert.ToDouble(Console.ReadLine());
            nickles = nickles * .05;

            Console.WriteLine("How many dimes do you have?");
            double dimes = Convert.ToDouble(Console.ReadLine());
            dimes = dimes * .10;

            Console.WriteLine("How many quarters do you have?");
            double quarters = Convert.ToDouble(Console.ReadLine());
            quarters = quarters * .25;

            Console.WriteLine("How many half dollars do you have?");
            double halfDollar = Convert.ToDouble(Console.ReadLine());
            halfDollar = halfDollar * .5;

            Console.WriteLine("How many gold dollars do you have?");
            double goldDollars = Convert.ToDouble(Console.ReadLine());
            goldDollars = goldDollars * 1;

            double moneySum = goldDollars + halfDollar + quarters + dimes + nickles + pennies;
            Console.WriteLine("Your piggy bank is valued at: $" + moneySum);

        }
    }
}
