using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int DieNumber;
            string WantToRoll;
            bool RunProgram = true;

            while (RunProgram == true)
            {
                //input - ask user to start
                Console.WriteLine("Welcome to the Grand Circus Casino! Would you like to roll the dice? (Y/N)");
                WantToRoll = Console.ReadLine();

                if (String.Compare(WantToRoll, "y", true) == 0) //validates that y is answered
                {
                    //continue program if yes

                    //input for number of sides on the die
                    Console.WriteLine("How many sides should each die have?");
 
                    if (int.TryParse(Console.ReadLine(), out DieNumber)) //validate input
                    {
                        //process & output
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("Thanks! You have rolled:");
                        System.Threading.Thread.Sleep(500);

                        //call RollDice 2x
                        Console.WriteLine(RollDice(1, DieNumber +1));
                        Console.WriteLine(RollDice(1, DieNumber + 1));
                    }
                    else //if a non-integer is entered
                    {
                        Console.WriteLine("Not a valid input. Please try again.");
                        System.Threading.Thread.Sleep(500);
                        Console.Clear();
                    }

                    //input - ask user to run again
                    Console.WriteLine();
                    Console.WriteLine("Roll again? (Y/N)");

                    if(String.Compare(Console.ReadLine(),"y", true) == 0) //run again
                    {
                        Console.Clear();
                        Console.WriteLine("Great! Here we go...");
                        System.Threading.Thread.Sleep(500);
                        Console.Clear();
                    }
                    else //no or invalid input
                    {
                        Console.Clear();
                        Console.WriteLine("Thanks for playing!");
                        System.Threading.Thread.Sleep(500);
                        RunProgram = false;
                    }


                }
                else if (String.Compare(WantToRoll, "n", true) == 0) //if user chooses not to play ("N")
                {
                    Console.Clear();
                    Console.WriteLine("Goodbye!. Press enter to exit the Casino.");
                    RunProgram = false;
                    Console.Read();
                }
                else //invalid input (not Y or N)
                {
                    Console.Clear();
                    Console.WriteLine("Not a valid input, please try again");
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                }
            }


        }

        //initialize the random object. doing this once will allow RollDice to get 2 diff random numbers, since it is not re-initialized
        private static Random Roll = new Random();

        //method to return 2 random numbers
        public static int RollDice(int lowNumber, int highNumber)
        {
            int Result = Roll.Next(lowNumber, highNumber);
                return Result;
        }
    }
}
