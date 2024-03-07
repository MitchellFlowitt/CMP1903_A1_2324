using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        public static void RunStart()
        {
            //asks to user to run the game or test until they enter a valid input
            int x = 0;
            while (true)
            {
                Console.WriteLine("would you like to run the game (1), test the game (2) or close the game (3)");
                //error handling in case the user enters a non integer value
                try
                {
                    x = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("please enter an integer");
                }
                if (x == 1 || x == 2 || x == 3)
                {
                    break;
                }
                Console.WriteLine("please enter only 1, 2 or 3");
            }
            if (x == 1)
            {
                RunGame();
            }
            else if (x == 2) 
            {
                RunTest();
            }
            else
            {
                //changes the static field in the game class so that the game can be closed
                Game.stillPlaying = false;
            }
        }
        public static void RunGame()
        {
            //creates a new game object
            Game game1 = new Game();

            //runs the game script to roll the dice
            game1.PlayGame();
        }

        public static void RunTest()
        {
            //creates a new testing object to check if the die and game classes are working properly
            Testing test = new Testing();
            test.TestDie();
            test.TestGame();
        }

        static void Main(string[] args)
        {
            while (Game.stillPlaying == true) 
            {
                RunStart();
            }
            Console.WriteLine("Thank you for playing");
            Console.ReadLine();
        }
    }
}
