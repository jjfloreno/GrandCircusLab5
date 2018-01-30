using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class DiceRollerApp
    {
        //initialize the random object. doing this once will allow RollDice to get 2 diff random numbers since it is not reinitializing each time
        private static Random Roll = new Random();

        //method to return 2 random numbers
        public static int RollDice(int lowNumber, int highNumber)
        {
            int Result = Roll.Next(lowNumber, highNumber);
            return Result;
        }

        //method to print messages based on special rolls
        public static string DisplayMessage(int Roll1, int Roll2)
        {
            if (Roll1 == 1 && Roll2 == 1)
                return "Snakeyes!";

            else if (Roll1 == 6 && Roll2 == 6)
                return "Boxcars!";

            else if (Roll1 + Roll2 == 7)
                return "Big red!";

            else if (Roll1 + Roll2 == 3)
                return "Ace deuce!";

            else
                return " ";
        }
    }
}
