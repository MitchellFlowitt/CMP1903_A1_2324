using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_for_assignment_1;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method

        //tests that the dice rolls are within the 1-6 range
        public void TestDie()
        {
            Die die1 = new Die();
            die1.Roll();
            Debug.Assert(die1.Value >= 1 && die1.Value <= 6);
            Console.WriteLine("dice working correctly");
        }

        //test to check that the sum of the 3 dice rolls are as expected
        public void TestGame()
        {
            Game game1 = new Game();
            int sumOfRolls = game1.RollDice();
            Debug.Assert(sumOfRolls >= 3 &&  sumOfRolls <= 18);
            Console.WriteLine("game working correctly");
        }
    }
}
