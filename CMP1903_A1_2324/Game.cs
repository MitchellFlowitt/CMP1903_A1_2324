using CMP1903_A1_2324;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        //game fields and properties
        private Die _die1;
        private Die _die2; 
        private Die _die3;
        private int _numOfRolls = 0;
        private int _currentRoll = 0;
        private int _highestRoll = 0;
        private int _lowestRoll = 18;
        private int _sumOfRolls = 0;

        //constructor that creats the dice objects
        public Game() 
        {
            _die1 = new Die();
            _die2 = new Die();
            _die3 = new Die();
        }

        //getters/setters
        public Die Die1 { get {  return _die1; } }
        public Die Die2 { get {  return _die2; } }
        public Die Die3 { get {  return _die3; } }
        public int NumOfRolls { get { return _numOfRolls; } }
        public int CurrentRoll { get {  return _currentRoll; } }
        public int HighestRoll { get { return _highestRoll; } }
        public int LowestRoll { get { return _lowestRoll; } }
        public int SumOfRolls { get { return _sumOfRolls;} }

        public void PlayGame()
        {

            //continuously rolls until STOP is entered
            Console.WriteLine("enter (STOP) to stop rolling");
            string x = "";
            while (x.ToLower() != "stop")
            {
                //rolls the 3 dice
                _die1.Roll();
                _die2.Roll();
                _die3.Roll();

                //prints out the rolls of each dice
                Console.WriteLine("the first die rolled "+_die1.Value);
                Console.WriteLine("the second die rolled "+_die2.Value);
                Console.WriteLine("the third die rolled "+_die3.Value);

                //edits the value for current, lowest and highest roll
                _currentRoll = _die1.Value + _die2.Value + _die3.Value;
                if (_currentRoll > _highestRoll) 
                {
                    _highestRoll = _currentRoll;
                }
                if (_currentRoll < _lowestRoll)
                {
                    _lowestRoll = _currentRoll;
                }
                //increments the number of rolls this game and updates the sum of all rolls
                _numOfRolls++;
                _sumOfRolls += _currentRoll; 

                //sums the rolls of each of the 3 dice
                Console.WriteLine();

                x = Console.ReadLine();
            }
            ShowStatistics();
        }

        //rolls the dice for the purposes of testing
        public int RollDice()
        {
            _die1.Roll();
            _die2.Roll();
            _die3.Roll();
            _sumOfRolls = _die1.Value + _die2.Value + _die3.Value;
            return _sumOfRolls;
        }

        //prints the lowest, highest and average roll
        public void ShowStatistics()
        {
            Console.WriteLine("the highest roll in that game was "+ _highestRoll);
            Console.WriteLine("the lowest roll in that game was "+ _lowestRoll);
            float averageRoll = _sumOfRolls / _numOfRolls;
            Console.WriteLine("the average roll that game was "+averageRoll);
        }
    }
}
