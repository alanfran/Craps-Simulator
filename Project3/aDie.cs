// Antonio Lanfranchi

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    /// <summary>
    /// Simulates a die.
    /// </summary>
    class aDie : Random
    {
        public aDie(int seed) : base(seed)
        {
            ;
        }
      
        /// <summary>
        /// Returns a random number from 1-6.
        /// </summary>
        /// <returns></returns>
        public int Roll()
        {
            // returns a random number from 1 to 6
            return this.Next(1, 7);
        }
        
        /// <summary>
        /// Simulates a game of craps. Input the game # so you can only print the first 5.
        /// </summary>
        /// <returns>1 if WIN, 0 if LOSE, -1 if ERROR</returns>
        public int simulateGame(int n, ref List<string> outputList, ref int nwin, ref int nlose)
        {
            if (n < 5)
            {
                outputList.Add("GAME " + (n+1).ToString() + " STARTED.");
            }

            // first, roll 2 dice
            int tmp1 = Roll();
            int tmp2 = Roll();

            int tmp = tmp1 + tmp2;
            rollCount[tmp]++;

            // first roll = {7, 11} -- WIN
            if (tmp == 7 || tmp == 11)
            {
                // WIN
                if (n < 5)
                {
                    outputList.Add("You rolled " + tmp1.ToString() + " and " + tmp2.ToString() + " for a total of " + tmp.ToString() + ". You WIN!");
                    outputList.Add("GAME " + (n+1).ToString() + " OVER.");
                    outputList.Add("");
                }
                nwin++;
                return 1;
            }
            // first roll = {2, 3, 12} -- LOSE
            else if (tmp == 2 || tmp == 3 || tmp == 12)
            {
                // LOSE
                if (n < 5)
                {
                    outputList.Add("You rolled " + tmp1.ToString() + " and " + tmp2.ToString() + " for a total of " + tmp.ToString() + ". You LOSE!");
                    outputList.Add("GAME " + (n+1).ToString() + " OVER.");
                    outputList.Add("");
                }
                nlose++;
                return 0;
            }
            // first roll = {else} -- point = sum
            else
            {
                int point = tmp;

                if (n < 5)
                {
                    outputList.Add("You rolled " + tmp1.ToString() + " and " + tmp2.ToString() + " for a total of " + tmp.ToString() + ". The point is " + tmp.ToString() + ". Roll again.");
                }
                tmp = 0;

                // {7} -- LOSE
                // {POINT} -- WIN
                while ((tmp != point) && (tmp != 7))
                {
                    // keep rolling until you get 7 or point
                    tmp1 = Roll();
                    tmp2 = Roll();
                    tmp = tmp1 + tmp2;
                    rollCount[tmp]++;

                    if (tmp != point && tmp != 7)       // stops duplicates when the value is point or 7
                    {
                        if (n < 5)
                        {
                            outputList.Add("You rolled " + tmp1.ToString() + " and " + tmp2.ToString() + " for a total of " + tmp.ToString() + ". Roll again.");
                        }
                    }
                }
                if (tmp == 7)
                {
                    // LOSE
                    if (n < 5)
                    {
                        outputList.Add("You rolled " + tmp1.ToString() + " and " + tmp2.ToString() + " for a total of " + tmp.ToString() + ". You LOSE!");
                        outputList.Add("GAME " + (n+1).ToString() + " OVER.");
                        outputList.Add("");
                    }
                    nlose++;
                    return 0;
                }
                else if (tmp == point)
                {
                    // WIN
                    if (n < 5)
                    {
                        outputList.Add("You rolled " + tmp1.ToString() + " and " + tmp2.ToString() + " for a total of " + tmp.ToString() + ". You WIN!");
                        outputList.Add("GAME " + (n+1).ToString() + " OVER.");
                        outputList.Add("");
                    }
                    nwin++;
                    return 1;
                }
                else
                {
                    // ERROR
                    return -1;
                }
               
            }
        }

        // store each game's rolls here
        // Pressing Go creates a new dice object, and a new, empty roll history
        public int[] rollCount = new int[13];
    }
}
